-- Generated by Oracle SQL Developer Data Modeler 17.2.0.188.1104
--   at:        2017-09-28 11:50:14 EEST
--   site:      Oracle Database 11g
--   type:      Oracle Database 11g



CREATE USER APPRAISALSYSTEM 
    IDENTIFIED BY  
    ACCOUNT UNLOCK 
;

GRANT CREATE SESSION, CREATE TABLE, UNLIMITED TABLESPACE TO APPRAISALSYSTEM 
;

CREATE TABLE appraisalsystem.competences (
    id    NUMBER(8) NOT NULL,
    key   VARCHAR2(50 BYTE) NOT NULL
)
    PCTFREE 10 PCTUSED 40 TABLESPACE system LOGGING
        STORAGE ( INITIAL 65536 NEXT 1048576 PCTINCREASE 0 MINEXTENTS 1 MAXEXTENTS 2147483645 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT );

ALTER TABLE appraisalsystem.competences
    ADD CONSTRAINT competences_pk PRIMARY KEY ( id )
        USING INDEX PCTFREE 10 INITRANS 2 TABLESPACE system LOGGING
            STORAGE ( INITIAL 65536 NEXT 1048576 PCTINCREASE 0 MINEXTENTS 1 MAXEXTENTS 2147483645 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT );

CREATE TABLE appraisalsystem.evaluation_templates (
    id                   NUMBER(8) NOT NULL,
    qualification_id     NUMBER(8) NOT NULL,
    excel_template       BLOB,
    excel_data_mapping   BLOB
)
    PCTFREE 10 PCTUSED 40 TABLESPACE system LOGGING
        STORAGE ( INITIAL 65536 NEXT 1048576 PCTINCREASE 0 MINEXTENTS 1 MAXEXTENTS 2147483645 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT )
        LOB ( excel_template ) STORE AS (
            TABLESPACE system
            STORAGE ( PCTINCREASE 0 MINEXTENTS 1 MAXEXTENTS UNLIMITED FREELISTS 1 BUFFER_POOL DEFAULT )
            CHUNK 8192
            RETENTION
            ENABLE STORAGE IN ROW
            NOCACHE LOGGING
        )
        LOB ( excel_data_mapping ) STORE AS (
            TABLESPACE system
            STORAGE ( PCTINCREASE 0 MINEXTENTS 1 MAXEXTENTS UNLIMITED FREELISTS 1 BUFFER_POOL DEFAULT )
            CHUNK 8192
            RETENTION
            ENABLE STORAGE IN ROW
            NOCACHE LOGGING
        );

ALTER TABLE appraisalsystem.evaluation_templates
    ADD CONSTRAINT evaluation_templates_pk PRIMARY KEY ( id )
        USING INDEX PCTFREE 10 INITRANS 2 TABLESPACE system LOGGING
            STORAGE ( INITIAL 65536 NEXT 1048576 PCTINCREASE 0 MINEXTENTS 1 MAXEXTENTS 2147483645 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT );

CREATE TABLE appraisalsystem.evaluations (
    id                       NUMBER(8) NOT NULL,
    user_id                  NUMBER(8) NOT NULL,
    evaluation_template_id   NUMBER(8) NOT NULL,
    eval_date                DATE
)
    PCTFREE 10 PCTUSED 40 TABLESPACE system LOGGING
        STORAGE ( INITIAL 65536 NEXT 1048576 PCTINCREASE 0 MINEXTENTS 1 MAXEXTENTS 2147483645 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT );

ALTER TABLE appraisalsystem.evaluations
    ADD CONSTRAINT evaluations_pk PRIMARY KEY ( id )
        USING INDEX PCTFREE 10 INITRANS 2 TABLESPACE system LOGGING
            STORAGE ( INITIAL 65536 NEXT 1048576 PCTINCREASE 0 MINEXTENTS 1 MAXEXTENTS 2147483645 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT );

CREATE TABLE appraisalsystem.evaluations_evaluators (
    evaluation_id   NUMBER(8) NOT NULL,
    evaluator_id    NUMBER(8) NOT NULL
)
    PCTFREE 10 PCTUSED 40 TABLESPACE system LOGGING
        STORAGE ( INITIAL 65536 NEXT 1048576 PCTINCREASE 0 MINEXTENTS 1 MAXEXTENTS 2147483645 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT );

CREATE UNIQUE INDEX appraisalsystem.pk_evaluation_evaluator ON
    appraisalsystem.evaluations_evaluators (
        evaluation_id
    ASC,
        evaluator_id
    ASC )
        TABLESPACE system PCTFREE 10
            STORAGE ( INITIAL 65536 NEXT 1048576 PCTINCREASE 0 MINEXTENTS 1 MAXEXTENTS 2147483645 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT )
        LOGGING;

ALTER TABLE appraisalsystem.evaluations_evaluators
    ADD CONSTRAINT pk_evaluation_evaluator PRIMARY KEY ( evaluation_id,evaluator_id )
        USING INDEX appraisalsystem.pk_evaluation_evaluator;

CREATE TABLE appraisalsystem.final_results (
    evaluation_id   NUMBER(8) NOT NULL,
    question_id     NUMBER(8) NOT NULL,
    rating_id       NUMBER(8) NOT NULL
)
    PCTFREE 10 PCTUSED 40 TABLESPACE system LOGGING
        STORAGE ( INITIAL 65536 NEXT 1048576 PCTINCREASE 0 MINEXTENTS 1 MAXEXTENTS 2147483645 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT );

CREATE TABLE appraisalsystem.positions (
    id     NUMBER(8) NOT NULL,
    name   VARCHAR2(50 BYTE) NOT NULL
)
    PCTFREE 10 PCTUSED 40 TABLESPACE system LOGGING
        STORAGE ( INITIAL 65536 NEXT 1048576 PCTINCREASE 0 MINEXTENTS 1 MAXEXTENTS 2147483645 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT );

ALTER TABLE appraisalsystem.positions
    ADD CONSTRAINT positions_pk PRIMARY KEY ( id )
        USING INDEX PCTFREE 10 INITRANS 2 TABLESPACE system LOGGING
            STORAGE ( INITIAL 65536 NEXT 1048576 PCTINCREASE 0 MINEXTENTS 1 MAXEXTENTS 2147483645 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT );

CREATE TABLE appraisalsystem.question_templates (
    question_id        NUMBER(8) NOT NULL,
    eval_template_id   NUMBER(8) NOT NULL
)
    PCTFREE 10 PCTUSED 40 TABLESPACE system LOGGING
        STORAGE ( INITIAL 65536 NEXT 1048576 PCTINCREASE 0 MINEXTENTS 1 MAXEXTENTS 2147483645 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT );

ALTER TABLE appraisalsystem.question_templates
    ADD CONSTRAINT question_templates_pk PRIMARY KEY ( question_id,eval_template_id )
        USING INDEX PCTFREE 10 INITRANS 2 TABLESPACE system LOGGING
            STORAGE ( INITIAL 65536 NEXT 1048576 PCTINCREASE 0 MINEXTENTS 1 MAXEXTENTS 2147483645 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT );

CREATE TABLE appraisalsystem.questions (
    id              NUMBER(8) NOT NULL,
    content         VARCHAR2(200 BYTE) NOT NULL,
    competence_id   NUMBER(8) NOT NULL
)
    PCTFREE 10 PCTUSED 40 TABLESPACE system LOGGING
        STORAGE ( INITIAL 65536 NEXT 1048576 PCTINCREASE 0 MINEXTENTS 1 MAXEXTENTS 2147483645 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT );

ALTER TABLE appraisalsystem.questions
    ADD CONSTRAINT questions_pk PRIMARY KEY ( id )
        USING INDEX PCTFREE 10 INITRANS 2 TABLESPACE system LOGGING
            STORAGE ( INITIAL 65536 NEXT 1048576 PCTINCREASE 0 MINEXTENTS 1 MAXEXTENTS 2147483645 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT );

CREATE TABLE appraisalsystem.ratings (
    id            NUMBER(8) NOT NULL,
    raiting       VARCHAR2(20 BYTE) NOT NULL,
    explanation   VARCHAR2(50 BYTE)
)
    PCTFREE 10 PCTUSED 40 TABLESPACE system LOGGING
        STORAGE ( INITIAL 65536 NEXT 1048576 PCTINCREASE 0 MINEXTENTS 1 MAXEXTENTS 2147483645 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT );

ALTER TABLE appraisalsystem.ratings
    ADD CONSTRAINT ratings_pk PRIMARY KEY ( id )
        USING INDEX PCTFREE 10 INITRANS 2 TABLESPACE system LOGGING
            STORAGE ( INITIAL 65536 NEXT 1048576 PCTINCREASE 0 MINEXTENTS 1 MAXEXTENTS 2147483645 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT );

CREATE TABLE appraisalsystem.results (
    evaluation_id   NUMBER(8) NOT NULL,
    question_id     NUMBER(8) NOT NULL,
    evaluator_id    NUMBER(8) NOT NULL,
    rating_id       NUMBER(8) NOT NULL,
    id              NUMBER(8) NOT NULL,
    is_final        NUMBER(1)
)
    PCTFREE 10 PCTUSED 40 TABLESPACE system LOGGING
        STORAGE ( INITIAL 65536 NEXT 1048576 PCTINCREASE 0 MINEXTENTS 1 MAXEXTENTS 2147483645 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT );

ALTER TABLE appraisalsystem.results
    ADD CONSTRAINT results_pk PRIMARY KEY ( id )
        USING INDEX PCTFREE 10 INITRANS 2 TABLESPACE system LOGGING
            STORAGE ( INITIAL 65536 NEXT 1048576 PCTINCREASE 0 MINEXTENTS 1 MAXEXTENTS 2147483645 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT );

CREATE TABLE appraisalsystem.roles (
    id          NUMBER(8) NOT NULL,
    role_name   VARCHAR2(50 BYTE) NOT NULL
)
    PCTFREE 10 PCTUSED 40 TABLESPACE system LOGGING
        STORAGE ( INITIAL 65536 NEXT 1048576 PCTINCREASE 0 MINEXTENTS 1 MAXEXTENTS 2147483645 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT );

ALTER TABLE appraisalsystem.roles
    ADD CONSTRAINT roles_pk PRIMARY KEY ( id )
        USING INDEX PCTFREE 10 INITRANS 2 TABLESPACE system LOGGING
            STORAGE ( INITIAL 65536 NEXT 1048576 PCTINCREASE 0 MINEXTENTS 1 MAXEXTENTS 2147483645 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT );

CREATE TABLE appraisalsystem.users (
    id           NUMBER(8) NOT NULL,
    first_name   VARCHAR2(50 BYTE) NOT NULL,
    last_name    VARCHAR2(50 BYTE) NOT NULL,
    password     VARCHAR2(40 BYTE) NOT NULL,
    email        VARCHAR2(40 BYTE) NOT NULL,
    role_id      NUMBER(8) NOT NULL
)
    PCTFREE 10 PCTUSED 40 TABLESPACE system LOGGING
        STORAGE ( INITIAL 65536 NEXT 1048576 PCTINCREASE 0 MINEXTENTS 1 MAXEXTENTS 2147483645 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT );

ALTER TABLE appraisalsystem.users
    ADD CONSTRAINT users_pk PRIMARY KEY ( id )
        USING INDEX PCTFREE 10 INITRANS 2 TABLESPACE system LOGGING
            STORAGE ( INITIAL 65536 NEXT 1048576 PCTINCREASE 0 MINEXTENTS 1 MAXEXTENTS 2147483645 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT );

ALTER TABLE appraisalsystem.users
    ADD FOREIGN KEY ( role_id )
        REFERENCES appraisalsystem.roles ( id )
    NOT DEFERRABLE;

ALTER TABLE appraisalsystem.questions
    ADD FOREIGN KEY ( competence_id )
        REFERENCES appraisalsystem.competences ( id )
    NOT DEFERRABLE;

ALTER TABLE appraisalsystem.evaluation_templates
    ADD FOREIGN KEY ( qualification_id )
        REFERENCES appraisalsystem.positions ( id )
    NOT DEFERRABLE;

ALTER TABLE appraisalsystem.evaluations
    ADD FOREIGN KEY ( user_id )
        REFERENCES appraisalsystem.users ( id )
    NOT DEFERRABLE;

ALTER TABLE appraisalsystem.evaluations_evaluators
    ADD FOREIGN KEY ( evaluation_id )
        REFERENCES appraisalsystem.evaluations ( id )
    NOT DEFERRABLE;

ALTER TABLE appraisalsystem.evaluations_evaluators
    ADD FOREIGN KEY ( evaluator_id )
        REFERENCES appraisalsystem.users ( id )
    NOT DEFERRABLE;

ALTER TABLE appraisalsystem.question_templates
    ADD FOREIGN KEY ( question_id )
        REFERENCES appraisalsystem.questions ( id )
    NOT DEFERRABLE;

ALTER TABLE appraisalsystem.question_templates
    ADD FOREIGN KEY ( eval_template_id )
        REFERENCES appraisalsystem.evaluation_templates ( id )
    NOT DEFERRABLE;

ALTER TABLE appraisalsystem.evaluations
    ADD FOREIGN KEY ( evaluation_template_id )
        REFERENCES appraisalsystem.evaluation_templates ( id )
    NOT DEFERRABLE;

ALTER TABLE appraisalsystem.results
    ADD FOREIGN KEY ( evaluation_id )
        REFERENCES appraisalsystem.evaluations ( id )
    NOT DEFERRABLE;

ALTER TABLE appraisalsystem.results
    ADD FOREIGN KEY ( question_id )
        REFERENCES appraisalsystem.questions ( id )
    NOT DEFERRABLE;

ALTER TABLE appraisalsystem.results
    ADD FOREIGN KEY ( evaluator_id )
        REFERENCES appraisalsystem.users ( id )
    NOT DEFERRABLE;

ALTER TABLE appraisalsystem.results
    ADD FOREIGN KEY ( rating_id )
        REFERENCES appraisalsystem.ratings ( id )
    NOT DEFERRABLE;

ALTER TABLE appraisalsystem.final_results
    ADD FOREIGN KEY ( evaluation_id )
        REFERENCES appraisalsystem.evaluations ( id )
    NOT DEFERRABLE;

ALTER TABLE appraisalsystem.final_results
    ADD FOREIGN KEY ( question_id )
        REFERENCES appraisalsystem.questions ( id )
    NOT DEFERRABLE;

ALTER TABLE appraisalsystem.final_results
    ADD FOREIGN KEY ( rating_id )
        REFERENCES appraisalsystem.ratings ( id )
    NOT DEFERRABLE;



-- Oracle SQL Developer Data Modeler Summary Report: 
-- 
-- CREATE TABLE                            12
-- CREATE INDEX                             1
-- ALTER TABLE                             27
-- CREATE VIEW                              0
-- ALTER VIEW                               0
-- CREATE PACKAGE                           0
-- CREATE PACKAGE BODY                      0
-- CREATE PROCEDURE                         0
-- CREATE FUNCTION                          0
-- CREATE TRIGGER                           0
-- ALTER TRIGGER                            0
-- CREATE COLLECTION TYPE                   0
-- CREATE STRUCTURED TYPE                   0
-- CREATE STRUCTURED TYPE BODY              0
-- CREATE CLUSTER                           0
-- CREATE CONTEXT                           0
-- CREATE DATABASE                          0
-- CREATE DIMENSION                         0
-- CREATE DIRECTORY                         0
-- CREATE DISK GROUP                        0
-- CREATE ROLE                              0
-- CREATE ROLLBACK SEGMENT                  0
-- CREATE SEQUENCE                          0
-- CREATE MATERIALIZED VIEW                 0
-- CREATE SYNONYM                           0
-- CREATE TABLESPACE                        0
-- CREATE USER                              1
-- 
-- DROP TABLESPACE                          0
-- DROP DATABASE                            0
-- 
-- REDACTION POLICY                         0
-- 
-- ORDS DROP SCHEMA                         0
-- ORDS ENABLE SCHEMA                       0
-- ORDS ENABLE OBJECT                       0
-- 
-- ERRORS                                   0
-- WARNINGS                                 0
