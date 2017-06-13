-- Generado por Oracle SQL Developer Data Modeler 4.2.0.932
--   en:        2017-06-13 09:32:42 CDT
--   sitio:      SQL Server 2008
--   tipo:      SQL Server 2008



CREATE TABLE AnalisisGas 
    (
     id INTEGER NOT NULL , 
     fuga BIT , 
     tiempo_rellenado DATETIME , 
     fase VARCHAR (1) , 
     humedad NUMERIC (5,2) , 
     sf6 NUMERIC (5,2) , 
     cf4 NUMERIC (5,2) , 
     so2 NUMERIC (5,2) , 
     HF NUMERIC (5,2) , 
     aire NUMERIC (5,2) , 
     presion NUMERIC (5,2) , 
     Prueba_id INTEGER NOT NULL 
    )
    ON "default"
GO 


ALTER TABLE AnalisisGas 
    ADD 
    CHECK ( fuga IN (NO, SI) ) 
GO


ALTER TABLE AnalisisGas 
    ADD 
    CHECK ( fase IN ('A', 'B', 'C') ) 
GO

ALTER TABLE AnalisisGas ADD CONSTRAINT AnalisisGas_PK PRIMARY KEY CLUSTERED (id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE AplicacionInterruptor 
    (
     id INTEGER NOT NULL , 
     descripción VARCHAR (50) 
    )
    ON "default"
GO

ALTER TABLE AplicacionInterruptor ADD CONSTRAINT AplicacionInterruptor_PK PRIMARY KEY CLUSTERED (id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE Archivo 
    (
     id INTEGER NOT NULL , 
     Prueba_id INTEGER NOT NULL , 
     fecha DATETIME , 
     archivo_soporte IMAGE 
    )
    ON "default"
GO

ALTER TABLE Archivo ADD CONSTRAINT Archivo_PK PRIMARY KEY CLUSTERED (id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE CondicionAislador 
    (
     id INTEGER NOT NULL , 
     corrosión BIT , 
     observaciones_corrosion VARCHAR (250) , 
     roturas BIT , 
     observaciones_roturas VARCHAR (250) , 
     grietas BIT , 
     observaciones_grietas VARCHAR (250) , 
     flameo BIT , 
     observaciones_flameo VARCHAR (250) , 
     danio_cementado BIT , 
     observaciones_cementado VARCHAR (250) , 
     danio_piezasfijacion BIT , 
     observaciones_piezasfijacion VARCHAR (250) , 
     Inspeccion_visual_id INTEGER NOT NULL 
    )
    ON "default"
GO 


ALTER TABLE CondicionAislador 
    ADD 
    CHECK ( corrosión IN (NO, SI) ) 
GO


ALTER TABLE CondicionAislador 
    ADD 
    CHECK ( roturas IN (NO, SI) ) 
GO


ALTER TABLE CondicionAislador 
    ADD 
    CHECK ( grietas IN (NO, SI) ) 
GO


ALTER TABLE CondicionAislador 
    ADD 
    CHECK ( flameo IN (NO, SI) ) 
GO


ALTER TABLE CondicionAislador 
    ADD 
    CHECK ( danio_cementado IN (NO, SI) ) 
GO


ALTER TABLE CondicionAislador 
    ADD 
    CHECK ( danio_piezasfijacion IN (NO, SI) ) 
GO

ALTER TABLE CondicionAislador ADD CONSTRAINT CondicionAislador_PK PRIMARY KEY CLUSTERED (id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE CondicionGabineteControl 
    (
     id INTEGER NOT NULL , 
     humedad BIT , 
     observaciones_humedad VARCHAR (250) , 
     roturas BIT , 
     observaciones_roturas VARCHAR (250) , 
     grietas_sello BIT , 
     observaciones_grietas VARCHAR (250) , 
     insectos BIT , 
     observaciones_insectos VARCHAR (250) , 
     desprendimiento_pintura BIT , 
     observaciones_pintura VARCHAR (250) , 
     corrosion_interna BIT , 
     observaciones_corrosioninterna VARCHAR (250) , 
     corrosion_externa BIT , 
     observaciones_corrosionexterna VARCHAR (250) , 
     disparo1 BIT , 
     observaciones_disparo1 VARCHAR (250) , 
     disparo2 BIT , 
     observaciones_disparo2 VARCHAR (250) , 
     cierre BIT , 
     observaciones_cierre VARCHAR (250) , 
     resistencia_calefactora BIT , 
     observaciones_rcalecfactora VARCHAR (250) , 
     Inspeccion_visual_id INTEGER NOT NULL 
    )
    ON "default"
GO 


ALTER TABLE CondicionGabineteControl 
    ADD 
    CHECK ( humedad IN (NO, SI) ) 
GO


ALTER TABLE CondicionGabineteControl 
    ADD 
    CHECK ( roturas IN (NO, SI) ) 
GO


ALTER TABLE CondicionGabineteControl 
    ADD 
    CHECK ( grietas_sello IN (NO, SI) ) 
GO


ALTER TABLE CondicionGabineteControl 
    ADD 
    CHECK ( insectos IN (NO, SI) ) 
GO


ALTER TABLE CondicionGabineteControl 
    ADD 
    CHECK ( desprendimiento_pintura IN (NO, SI) ) 
GO


ALTER TABLE CondicionGabineteControl 
    ADD 
    CHECK ( corrosion_interna IN (NO, SI) ) 
GO


ALTER TABLE CondicionGabineteControl 
    ADD 
    CHECK ( corrosion_externa IN (NO, SI) ) 
GO


ALTER TABLE CondicionGabineteControl 
    ADD 
    CHECK ( disparo1 IN (NO, SI) ) 
GO


ALTER TABLE CondicionGabineteControl 
    ADD 
    CHECK ( disparo2 IN (NO, SI) ) 
GO


ALTER TABLE CondicionGabineteControl 
    ADD 
    CHECK ( cierre IN (NO, SI) ) 
GO


ALTER TABLE CondicionGabineteControl 
    ADD 
    CHECK ( resistencia_calefactora IN (NO, SI) ) 
GO

ALTER TABLE CondicionGabineteControl ADD CONSTRAINT CondicionGabineteControl_PK PRIMARY KEY CLUSTERED (id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE CondicionOtrosComponentes 
    (
     id INTEGER NOT NULL , 
     aterrizamiento_cdisparo BIT , 
     observaciones_aterrizamiento VARCHAR (250) , 
     corrosion_tubing BIT , 
     observaciones_ctubing VARCHAR (250) , 
     corrosion_ctierra BIT , 
     observaciones_ctierra VARCHAR (250) , 
     ruido_audible BIT , 
     observaciones_ruidoaudible VARCHAR (250) , 
     vibracion_audible BIT , 
     observaciones_vibracionaudible VARCHAR (250) , 
     instrumento_medicionSF6 BIT , 
     Inspeccion_visual_id INTEGER NOT NULL 
    )
    ON "default"
GO 


ALTER TABLE CondicionOtrosComponentes 
    ADD 
    CHECK ( aterrizamiento_cdisparo IN (NO, SI) ) 
GO


ALTER TABLE CondicionOtrosComponentes 
    ADD 
    CHECK ( corrosion_tubing IN (NO, SI) ) 
GO


ALTER TABLE CondicionOtrosComponentes 
    ADD 
    CHECK ( corrosion_ctierra IN (NO, SI) ) 
GO


ALTER TABLE CondicionOtrosComponentes 
    ADD 
    CHECK ( ruido_audible IN (NO, SI) ) 
GO


ALTER TABLE CondicionOtrosComponentes 
    ADD 
    CHECK ( vibracion_audible IN (NO, SI) ) 
GO


ALTER TABLE CondicionOtrosComponentes 
    ADD 
    CHECK ( instrumento_medicionSF6 IN (NO, SI) ) 
GO

ALTER TABLE CondicionOtrosComponentes ADD CONSTRAINT CondicionOtrosComponentes_PK PRIMARY KEY CLUSTERED (id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE CondicionVarillaje 
    (
     id INTEGER NOT NULL , 
     alineacion BIT , 
     observaciones_alineacion VARCHAR (250) , 
     lubricacion BIT , 
     observaciones_lubricacion VARCHAR (250) , 
     Inspeccion_visual_id INTEGER NOT NULL 
    )
    ON "default"
GO 


ALTER TABLE CondicionVarillaje 
    ADD 
    CHECK ( alineacion IN (NO, SI) ) 
GO


ALTER TABLE CondicionVarillaje 
    ADD 
    CHECK ( lubricacion IN (NO, SI) ) 
GO

ALTER TABLE CondicionVarillaje ADD CONSTRAINT CondicionVarillaje_PK PRIMARY KEY CLUSTERED (id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE Densimetro 
    (
     id INTEGER NOT NULL , 
     carcasa VARCHAR (2) , 
     observaciones_carcasa VARCHAR (250) , 
     caratula VARCHAR (2) , 
     observaciones_caratula VARCHAR (250) , 
     escala VARCHAR (2) , 
     observaciones_escala VARCHAR (250) , 
     presionSF6_va NUMERIC (6,2) , 
     presionSF6_vn NUMERIC (6,2) , 
     observaciones_presionSF6 VARCHAR (250) , 
     temperatura_va NUMERIC (6,2) , 
     temperatura_vn NUMERIC (6,2) , 
     observaciones_temperatura VARCHAR (250) , 
     Inspeccion_visual_id INTEGER NOT NULL 
    )
    ON "default"
GO 


ALTER TABLE Densimetro 
    ADD 
    CHECK ( carcasa IN ('BE', 'ME') ) 
GO


ALTER TABLE Densimetro 
    ADD 
    CHECK ( caratula IN ('BE', 'ME') ) 
GO


ALTER TABLE Densimetro 
    ADD 
    CHECK ( escala IN ('BE', 'ME') ) 
GO

ALTER TABLE Densimetro ADD CONSTRAINT Densimetro_PK PRIMARY KEY CLUSTERED (id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE Equipo 
    (
     id INTEGER NOT NULL , 
     Gerencia_id INTEGER NOT NULL , 
     Subestacion_id INTEGER NOT NULL , 
     Marca_id INTEGER NOT NULL , 
     Mecanismo_id INTEGER NOT NULL , 
     bahia VARCHAR (5) , 
     ns VARCHAR (20) , 
     modelo_tipo VARCHAR (20) , 
     Anio_fabricacion NUMERIC (4) , 
     tesion_nominal NUMERIC (5,2) , 
     corriente_nominal NUMERIC (5,2) , 
     corriente_cc NUMERIC (5,2) , 
     bil NUMERIC (6,3) , 
     presionSF6 NUMERIC (6,3) , 
     altitudoperacion NUMERIC (4) , 
     dis_estructural VARCHAR (2) , 
     conf_camaras VARCHAR (1) , 
     res_estatica_contactos NUMERIC (6,2) , 
     interruptor_contiene VARCHAR (1) , 
     interruptor_resistencia NUMERIC (6,2) , 
     interruptor_capacitor NUMERIC (6,2) 
    )
    ON "default"
GO

ALTER TABLE Equipo ADD CONSTRAINT Equipo_PK PRIMARY KEY CLUSTERED (id, Gerencia_id, Mecanismo_id, Subestacion_id, Marca_id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE Gerencia 
    (
     id INTEGER NOT NULL , 
     nombre VARCHAR (50) 
    )
    ON "default"
GO

ALTER TABLE Gerencia ADD CONSTRAINT Gerencia_PK PRIMARY KEY CLUSTERED (id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE Inspeccion_visual 
    (
     id INTEGER NOT NULL , 
     Prueba_id INTEGER NOT NULL , 
     AplicacionInterruptor_id INTEGER NOT NULL , 
     fecha_inspeccion DATE , 
     fecha_puestaservicio DATE , 
     fase VARCHAR (1) , 
     num_operaciones INTEGER , 
     existe_gabinete BIT 
    )
    ON "default"
GO 


ALTER TABLE Inspeccion_visual 
    ADD 
    CHECK ( existe_gabinete IN (NO, SI) ) 
GO

ALTER TABLE Inspeccion_visual ADD CONSTRAINT Inspeccion_visual_PK PRIMARY KEY CLUSTERED (id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE Marca 
    (
     id INTEGER NOT NULL , 
     nombre VARCHAR (50) 
    )
    ON "default"
GO

ALTER TABLE Marca ADD CONSTRAINT Marca_PK PRIMARY KEY CLUSTERED (id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE Mecanismo 
    (
     id INTEGER NOT NULL , 
     descripcion VARCHAR (50) 
    )
    ON "default"
GO

ALTER TABLE Mecanismo ADD CONSTRAINT Mecanismo_PK PRIMARY KEY CLUSTERED (id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE MecanismoHidraulico 
    (
     id INTEGER NOT NULL , 
     fuga_aceite VARCHAR (2) , 
     observaciones_fugaa VARCHAR (250) , 
     acumulador VARCHAR (2) , 
     observaciones_acumulador VARCHAR (250) , 
     presion_aceite VARCHAR (2) , 
     observaciones_presiona VARCHAR (250) , 
     unidad_control VARCHAR (2) , 
     observaciones_uctrl VARCHAR (250) , 
     valvulas VARCHAR (2) , 
     observaciones_valvulas VARCHAR (250) , 
     trecarga_acumulador VARCHAR (2) , 
     observaciones_trecargaa VARCHAR (250) , 
     burbujas_reservorio VARCHAR (2) , 
     observaciones_burbujasr VARCHAR (250) , 
     fugas_nitrogeno VARCHAR (2) , 
     observaciones_fugasnitro VARCHAR (250) , 
     compresor VARCHAR (2) , 
     observaciones_compresor VARCHAR (250) , 
     Inspeccion_visual_id INTEGER NOT NULL 
    )
    ON "default"
GO 


ALTER TABLE MecanismoHidraulico 
    ADD 
    CHECK ( fuga_aceite IN ('BE', 'ME') ) 
GO


ALTER TABLE MecanismoHidraulico 
    ADD 
    CHECK ( acumulador IN ('BE', 'ME') ) 
GO


ALTER TABLE MecanismoHidraulico 
    ADD 
    CHECK ( presion_aceite IN ('BE', 'ME') ) 
GO


ALTER TABLE MecanismoHidraulico 
    ADD 
    CHECK ( unidad_control IN ('BE', 'ME') ) 
GO


ALTER TABLE MecanismoHidraulico 
    ADD 
    CHECK ( valvulas IN ('BE', 'ME') ) 
GO


ALTER TABLE MecanismoHidraulico 
    ADD 
    CHECK ( trecarga_acumulador IN ('BE', 'ME') ) 
GO


ALTER TABLE MecanismoHidraulico 
    ADD 
    CHECK ( burbujas_reservorio IN ('BE', 'ME') ) 
GO


ALTER TABLE MecanismoHidraulico 
    ADD 
    CHECK ( fugas_nitrogeno IN ('BE', 'ME') ) 
GO


ALTER TABLE MecanismoHidraulico 
    ADD 
    CHECK ( compresor IN ('BE', 'ME') ) 
GO

ALTER TABLE MecanismoHidraulico ADD CONSTRAINT MecanismoHidraulico_PK PRIMARY KEY CLUSTERED (id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE MecanismoNeumatico 
    (
     id INTEGER NOT NULL , 
     presion_aire VARCHAR (2) , 
     observaciones_presionaire VARCHAR (250) , 
     fuga_aire VARCHAR (2) , 
     observaciones_fugaaire VARCHAR (250) , 
     valvulas VARCHAR (2) , 
     observaciones_valvulas VARCHAR (250) , 
     corrosion_mecanismo VARCHAR (2) , 
     observaciones_corrmecan VARCHAR (250) , 
     Inspeccion_visual_id INTEGER NOT NULL 
    )
    ON "default"
GO 


ALTER TABLE MecanismoNeumatico 
    ADD 
    CHECK ( presion_aire IN ('BE', 'ME') ) 
GO


ALTER TABLE MecanismoNeumatico 
    ADD 
    CHECK ( fuga_aire IN ('BE', 'ME') ) 
GO


ALTER TABLE MecanismoNeumatico 
    ADD 
    CHECK ( valvulas IN ('BE', 'ME') ) 
GO


ALTER TABLE MecanismoNeumatico 
    ADD 
    CHECK ( corrosion_mecanismo IN ('BE', 'ME') ) 
GO

ALTER TABLE MecanismoNeumatico ADD CONSTRAINT MecanismoNeumatico_PK PRIMARY KEY CLUSTERED (id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE MecanismoResortes 
    (
     id INTEGER NOT NULL , 
     alineacion_resortes VARCHAR (2) , 
     observaciones_alin_resortes VARCHAR (250) , 
     amortiguadores VARCHAR (2) , 
     observaciones_amortiguadores VARCHAR (250) , 
     motor VARCHAR (2) , 
     observaciones_motor VARCHAR (250) , 
     Inspeccion_visual_id INTEGER NOT NULL 
    )
    ON "default"
GO 


ALTER TABLE MecanismoResortes 
    ADD 
    CHECK ( alineacion_resortes IN ('BE', 'ME') ) 
GO


ALTER TABLE MecanismoResortes 
    ADD 
    CHECK ( amortiguadores IN ('BE', 'ME') ) 
GO


ALTER TABLE MecanismoResortes 
    ADD 
    CHECK ( motor IN ('BE', 'ME') ) 
GO

ALTER TABLE MecanismoResortes ADD CONSTRAINT MecanismoResortes_PK PRIMARY KEY CLUSTERED (id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE Presostato 
    (
     id INTEGER NOT NULL , 
     carcasa VARCHAR (2) , 
     observaciones_carcasa VARCHAR (250) , 
     caratula VARCHAR (2) , 
     observaciones_caratula VARCHAR (250) , 
     escala VARCHAR (2) , 
     observaciones_escala VARCHAR (250) , 
     presionSF6_va NUMERIC (6,2) , 
     presionSF6_vn NUMERIC (6,2) , 
     observaciones_presionSF6 VARCHAR (250) , 
     temperatura_va NUMERIC (6,2) , 
     temperatura_vn NUMERIC (6,2) , 
     observaciones_temperatura VARCHAR (250) , 
     Inspeccion_visual_id INTEGER NOT NULL 
    )
    ON "default"
GO 


ALTER TABLE Presostato 
    ADD 
    CHECK ( carcasa IN ('BE', 'ME') ) 
GO


ALTER TABLE Presostato 
    ADD 
    CHECK ( caratula IN ('BE', 'ME') ) 
GO


ALTER TABLE Presostato 
    ADD 
    CHECK ( escala IN ('BE', 'ME') ) 
GO

ALTER TABLE Presostato ADD CONSTRAINT Presostato_PK PRIMARY KEY CLUSTERED (id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE Prueba 
    (
     id INTEGER NOT NULL , 
     Equipo_id INTEGER NOT NULL , 
     fecha DATE NOT NULL , 
     Equipo_Gerencia_id INTEGER NOT NULL , 
     Equipo_Mecanismo_id INTEGER NOT NULL , 
     Equipo_Subestacion_id INTEGER NOT NULL , 
     Equipo_Marca_id INTEGER NOT NULL 
    )
    ON "default"
GO

ALTER TABLE Prueba ADD CONSTRAINT Prueba_PK PRIMARY KEY CLUSTERED (id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE PruebaEspecial 
    (
     Id INTEGER , 
     Prueba_id INTEGER NOT NULL , 
     res_dim_con_fasea VARCHAR (1) , 
     res_dim_con_faseb VARCHAR (1) , 
     res_dim_con_fasec VARCHAR (1) , 
     temp_ambiente NUMERIC (6,2) , 
     tfasea NUMERIC (6,2) , 
     ubicacion_tempfasea VARCHAR (4) , 
     tfaseb NUMERIC (6,2) , 
     ubicacion_tempfaseb VARCHAR (4) , 
     tfasec NUMERIC (6,2) , 
     ubicacion_tempfasec VARCHAR (4) , 
     patron_iba1 VARCHAR (1) , 
     patron_iba2 VARCHAR (1) , 
     patron_tba1 VARCHAR (1) , 
     patron_tba2 VARCHAR (1) , 
     patron_ibacierre VARCHAR (1) , 
     patron_tbacierre VARCHAR (1) , 
     parranque_minimo NUMERIC (6,2) , 
     caida_ibobinad1 NUMERIC (6,2) , 
     caida_ibobinad2 NUMERIC (6,2) , 
     caida_ibobinacierre NUMERIC (6,2) , 
     vaperturad1 NUMERIC (6,2) , 
     vaperturad2 NUMERIC (6,2) , 
     vcierre NUMERIC (6,2) , 
     ctotal_capertura1 NUMERIC (6,2) , 
     ctotal_capertura2 NUMERIC (6,2) , 
     ctotal_ccierre NUMERIC (6,2) , 
     recorrido_capertura1 NUMERIC (6,2) , 
     recorrido_capertura2 NUMERIC (6,2) , 
     recorrido_ccierre NUMERIC (6,2) , 
     penetracion NUMERIC (6,2) , 
     rebote_apertura1 NUMERIC (6,2) , 
     rebote_apertura2 NUMERIC (6,2) , 
     rebote_cierre NUMERIC (6,2) , 
     sobrerecorrido_apertura1 NUMERIC (6,2) , 
     sobrerecorrido_apertura2 NUMERIC (6,2) , 
     sobrerecorrido_cierre NUMERIC (6,2) 
    )
    ON "default"
GO 


ALTER TABLE PruebaEspecial 
    ADD 
    CHECK ( res_dim_con_fasea IN ('A', 'N') ) 
GO


ALTER TABLE PruebaEspecial 
    ADD 
    CHECK ( res_dim_con_faseb IN ('A', 'N') ) 
GO


ALTER TABLE PruebaEspecial 
    ADD 
    CHECK ( res_dim_con_fasec IN ('A', 'N') ) 
GO


ALTER TABLE PruebaEspecial 
    ADD 
    CHECK ( ubicacion_tempfasea IN ('TLCU', 'TLTC') ) 
GO


ALTER TABLE PruebaEspecial 
    ADD 
    CHECK ( ubicacion_tempfaseb IN ('TLCU', 'TLTC') ) 
GO


ALTER TABLE PruebaEspecial 
    ADD 
    CHECK ( ubicacion_tempfasec IN ('TLCU', 'TLTC') ) 
GO


ALTER TABLE PruebaEspecial 
    ADD 
    CHECK ( patron_iba1 IN ('A', 'N') ) 
GO


ALTER TABLE PruebaEspecial 
    ADD 
    CHECK ( patron_iba2 IN ('A', 'N') ) 
GO


ALTER TABLE PruebaEspecial 
    ADD 
    CHECK ( patron_tba1 IN ('A', 'N') ) 
GO


ALTER TABLE PruebaEspecial 
    ADD 
    CHECK ( patron_tba2 IN ('A', 'N') ) 
GO


ALTER TABLE PruebaEspecial 
    ADD 
    CHECK ( patron_ibacierre IN ('A', 'N') ) 
GO


ALTER TABLE PruebaEspecial 
    ADD 
    CHECK ( patron_tbacierre IN ('A', 'N') ) 
GO

CREATE TABLE PruebaRutina 
    (
     id INTEGER NOT NULL , 
     Prueba_id INTEGER NOT NULL , 
     ibobina_disparo1 NUMERIC (6,2) , 
     ibobina_disparo2 NUMERIC (6,2) , 
     ibobina_cierre NUMERIC (6,2) , 
     tapertura_fasead1 INTEGER , 
     tapertura_fasebd1 INTEGER , 
     tapertura_fasecd1 INTEGER , 
     tapertura_fasead2 INTEGER , 
     tapertura_fasebd2 INTEGER , 
     tapertura_fasecd2 INTEGER , 
     tcierre_fasea INTEGER , 
     tcierre_faseb INTEGER , 
     tcierre_fasec INTEGER , 
     pantibombeo BIT , 
     imotor_ienergizacion NUMERIC (6,2) , 
     imotor_tcarga INTEGER , 
     fultimo_mantenimiento DATE , 
     num_operfallas INTEGER , 
     disponibilidad VARCHAR (1) , 
     altitud_instalacion INTEGER , 
     nivel_contaminacion VARCHAR , 
     rec_1cfasea NUMERIC (6,2) , 
     rec_1cfaseb NUMERIC (6,2) , 
     rec_1cfasec NUMERIC (6,2) , 
     rec_2cfasea_c1 NUMERIC (6,2) , 
     rec_2cfasea_c2 NUMERIC (6,2) , 
     rec_2cfaseb_c1 NUMERIC (6,2) , 
     rec_2cfaseb_c2 NUMERIC (6,2) , 
     rec_2cfasec_c1 NUMERIC (6,2) , 
     rec_2cfasec_c2 NUMERIC (6,2) , 
     resitencia_preinsercion NUMERIC (6,2) , 
     capacitancia_capacitor NUMERIC (6,2) 
    )
    ON "default"
GO 


ALTER TABLE PruebaRutina 
    ADD 
    CHECK ( pantibombeo IN (NO, SI) ) 
GO


ALTER TABLE PruebaRutina 
    ADD 
    CHECK ( disponibilidad IN ('A', 'B', 'M') ) 
GO

ALTER TABLE PruebaRutina ADD CONSTRAINT PruebaRutina_PK PRIMARY KEY CLUSTERED (id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

CREATE TABLE Subestacion 
    (
     id INTEGER NOT NULL , 
     nombre VARCHAR (50) 
    )
    ON "default"
GO

ALTER TABLE Subestacion ADD CONSTRAINT Subestacion_PK PRIMARY KEY CLUSTERED (id)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
     ON "default" 
    GO

ALTER TABLE AnalisisGas 
    ADD CONSTRAINT AnalisisGas_Prueba_FK FOREIGN KEY 
    ( 
     Prueba_id
    ) 
    REFERENCES Prueba 
    ( 
     id 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Archivo 
    ADD CONSTRAINT Archivo_Prueba_FK FOREIGN KEY 
    ( 
     Prueba_id
    ) 
    REFERENCES Prueba 
    ( 
     id 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE CondicionAislador 
    ADD CONSTRAINT CondicionAislador_Inspeccion_visual_FK FOREIGN KEY 
    ( 
     Inspeccion_visual_id
    ) 
    REFERENCES Inspeccion_visual 
    ( 
     id 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE CondicionGabineteControl 
    ADD CONSTRAINT CondicionGabineteControl_Inspeccion_visual_FK FOREIGN KEY 
    ( 
     Inspeccion_visual_id
    ) 
    REFERENCES Inspeccion_visual 
    ( 
     id 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE CondicionOtrosComponentes 
    ADD CONSTRAINT CondicionOtrosComponentes_Inspeccion_visual_FK FOREIGN KEY 
    ( 
     Inspeccion_visual_id
    ) 
    REFERENCES Inspeccion_visual 
    ( 
     id 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE CondicionVarillaje 
    ADD CONSTRAINT CondicionVarillaje_Inspeccion_visual_FK FOREIGN KEY 
    ( 
     Inspeccion_visual_id
    ) 
    REFERENCES Inspeccion_visual 
    ( 
     id 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Densimetro 
    ADD CONSTRAINT Densimetro_Inspeccion_visual_FK FOREIGN KEY 
    ( 
     Inspeccion_visual_id
    ) 
    REFERENCES Inspeccion_visual 
    ( 
     id 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Equipo 
    ADD CONSTRAINT Equipo_Gerencia_FK FOREIGN KEY 
    ( 
     Gerencia_id
    ) 
    REFERENCES Gerencia 
    ( 
     id 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Equipo 
    ADD CONSTRAINT Equipo_Marca_FK FOREIGN KEY 
    ( 
     Marca_id
    ) 
    REFERENCES Marca 
    ( 
     id 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Equipo 
    ADD CONSTRAINT Equipo_Mecanismo_FK FOREIGN KEY 
    ( 
     Mecanismo_id
    ) 
    REFERENCES Mecanismo 
    ( 
     id 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Equipo 
    ADD CONSTRAINT Equipo_Subestacion_FK FOREIGN KEY 
    ( 
     Subestacion_id
    ) 
    REFERENCES Subestacion 
    ( 
     id 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Inspeccion_visual 
    ADD CONSTRAINT Inspeccion_visual_AplicacionInterruptor_FK FOREIGN KEY 
    ( 
     AplicacionInterruptor_id
    ) 
    REFERENCES AplicacionInterruptor 
    ( 
     id 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Inspeccion_visual 
    ADD CONSTRAINT Inspeccion_visual_Prueba_FK FOREIGN KEY 
    ( 
     Prueba_id
    ) 
    REFERENCES Prueba 
    ( 
     id 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE MecanismoHidraulico 
    ADD CONSTRAINT MecanismoHidraulico_Inspeccion_visual_FK FOREIGN KEY 
    ( 
     Inspeccion_visual_id
    ) 
    REFERENCES Inspeccion_visual 
    ( 
     id 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE MecanismoNeumatico 
    ADD CONSTRAINT MecanismoNeumatico_Inspeccion_visual_FK FOREIGN KEY 
    ( 
     Inspeccion_visual_id
    ) 
    REFERENCES Inspeccion_visual 
    ( 
     id 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE MecanismoResortes 
    ADD CONSTRAINT MecanismoResortes_Inspeccion_visual_FK FOREIGN KEY 
    ( 
     Inspeccion_visual_id
    ) 
    REFERENCES Inspeccion_visual 
    ( 
     id 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Presostato 
    ADD CONSTRAINT Presostato_Inspeccion_visual_FK FOREIGN KEY 
    ( 
     Inspeccion_visual_id
    ) 
    REFERENCES Inspeccion_visual 
    ( 
     id 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE Prueba 
    ADD CONSTRAINT Prueba_Equipo_FK FOREIGN KEY 
    ( 
     Equipo_id, 
     Equipo_Gerencia_id, 
     Equipo_Mecanismo_id, 
     Equipo_Subestacion_id, 
     Equipo_Marca_id
    ) 
    REFERENCES Equipo 
    ( 
     id , 
     Gerencia_id , 
     Mecanismo_id , 
     Subestacion_id , 
     Marca_id 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE PruebaEspecial 
    ADD CONSTRAINT PruebaEspecial_Prueba_FK FOREIGN KEY 
    ( 
     Prueba_id
    ) 
    REFERENCES Prueba 
    ( 
     id 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO

ALTER TABLE PruebaRutina 
    ADD CONSTRAINT PruebaRutina_Prueba_FK FOREIGN KEY 
    ( 
     Prueba_id
    ) 
    REFERENCES Prueba 
    ( 
     id 
    ) 
    ON DELETE NO ACTION 
    ON UPDATE NO ACTION 
GO



-- Informe de Resumen de Oracle SQL Developer Data Modeler: 
-- 
-- CREATE TABLE                            21
-- CREATE INDEX                             0
-- ALTER TABLE                            104
-- CREATE VIEW                              0
-- ALTER VIEW                               0
-- CREATE PACKAGE                           0
-- CREATE PACKAGE BODY                      0
-- CREATE PROCEDURE                         0
-- CREATE FUNCTION                          0
-- CREATE TRIGGER                           0
-- ALTER TRIGGER                            0
-- CREATE DATABASE                          0
-- CREATE DEFAULT                           0
-- CREATE INDEX ON VIEW                     0
-- CREATE ROLLBACK SEGMENT                  0
-- CREATE ROLE                              0
-- CREATE RULE                              0
-- CREATE SCHEMA                            0
-- CREATE PARTITION FUNCTION                0
-- CREATE PARTITION SCHEME                  0
-- 
-- DROP DATABASE                            0
-- 
-- ERRORS                                   0
-- WARNINGS                                 0
