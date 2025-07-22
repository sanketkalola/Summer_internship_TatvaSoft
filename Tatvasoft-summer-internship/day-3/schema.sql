-- Table: public.User

-- DROP TABLE IF EXISTS public."User";

CREATE TABLE IF NOT EXISTS public."User"
(
    id integer NOT NULL DEFAULT nextval('"User_id_seq"'::regclass),
    firstname text COLLATE pg_catalog."default" NOT NULL,
    lastname text COLLATE pg_catalog."default" NOT NULL,
    emailaddress text COLLATE pg_catalog."default" NOT NULL,
    password text COLLATE pg_catalog."default" NOT NULL,
    phonenumber text COLLATE pg_catalog."default" NOT NULL,
    usertype text COLLATE pg_catalog."default" NOT NULL,
    userimage text COLLATE pg_catalog."default" NOT NULL DEFAULT ''::text,
    createddate timestamp with time zone NOT NULL,
    modifieddate timestamp with time zone NOT NULL,
    isdeleted boolean NOT NULL DEFAULT false,
    CONSTRAINT "User_pkey" PRIMARY KEY (id),
    CONSTRAINT "User_emailaddress_key" UNIQUE (emailaddress)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public."User"
    OWNER to postgres;