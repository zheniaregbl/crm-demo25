toc.dat                                                                                             0000600 0004000 0002000 00000030467 14765724220 0014462 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        PGDMP   ;    +                }            crm_demo    16.0    16.0 .    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false         �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false         �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false         �           1262    18147    crm_demo    DATABASE     |   CREATE DATABASE crm_demo WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';
    DROP DATABASE crm_demo;
                postgres    false         ]           1247    18190    request_status    TYPE     �   CREATE TYPE public.request_status AS ENUM (
    'новая',
    'в процессе ремонта',
    'готова к выдаче'
);
 !   DROP TYPE public.request_status;
       public          postgres    false         Q           1247    18149 	   user_type    TYPE     �   CREATE TYPE public.user_type AS ENUM (
    'заказчик',
    'мастер',
    'менеджер',
    'оператор'
);
    DROP TYPE public.user_type;
       public          postgres    false         �            1259    18255    comment    TABLE     }   CREATE TABLE public.comment (
    id integer NOT NULL,
    request integer,
    master integer,
    message text NOT NULL
);
    DROP TABLE public.comment;
       public         heap    postgres    false         �            1259    18254    comment_id_seq    SEQUENCE     �   CREATE SEQUENCE public.comment_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 %   DROP SEQUENCE public.comment_id_seq;
       public          postgres    false    224         �           0    0    comment_id_seq    SEQUENCE OWNED BY     A   ALTER SEQUENCE public.comment_id_seq OWNED BY public.comment.id;
          public          postgres    false    223         �            1259    18176 	   home_tech    TABLE     f   CREATE TABLE public.home_tech (
    id integer NOT NULL,
    type integer,
    model text NOT NULL
);
    DROP TABLE public.home_tech;
       public         heap    postgres    false         �            1259    18175    home_tech_id_seq    SEQUENCE     �   CREATE SEQUENCE public.home_tech_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.home_tech_id_seq;
       public          postgres    false    220         �           0    0    home_tech_id_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.home_tech_id_seq OWNED BY public.home_tech.id;
          public          postgres    false    219         �            1259    18236    request    TABLE     �   CREATE TABLE public.request (
    id integer NOT NULL,
    master integer,
    client integer,
    start_date date NOT NULL,
    home_tech integer,
    problem_desc text NOT NULL,
    status public.request_status NOT NULL,
    completion_date date
);
    DROP TABLE public.request;
       public         heap    postgres    false    861         �            1259    18235    request_id_seq    SEQUENCE     �   CREATE SEQUENCE public.request_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 %   DROP SEQUENCE public.request_id_seq;
       public          postgres    false    222         �           0    0    request_id_seq    SEQUENCE OWNED BY     A   ALTER SEQUENCE public.request_id_seq OWNED BY public.request.id;
          public          postgres    false    221         �            1259    18167 	   tech_type    TABLE     S   CREATE TABLE public.tech_type (
    id integer NOT NULL,
    name text NOT NULL
);
    DROP TABLE public.tech_type;
       public         heap    postgres    false         �            1259    18166    tech_type_id_seq    SEQUENCE     �   CREATE SEQUENCE public.tech_type_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.tech_type_id_seq;
       public          postgres    false    218         �           0    0    tech_type_id_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.tech_type_id_seq OWNED BY public.tech_type.id;
          public          postgres    false    217         �            1259    18158    users    TABLE     �   CREATE TABLE public.users (
    id integer NOT NULL,
    fio text NOT NULL,
    phone text NOT NULL,
    login text NOT NULL,
    password text NOT NULL,
    type public.user_type NOT NULL
);
    DROP TABLE public.users;
       public         heap    postgres    false    849         �            1259    18157    users_id_seq    SEQUENCE     �   CREATE SEQUENCE public.users_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.users_id_seq;
       public          postgres    false    216         �           0    0    users_id_seq    SEQUENCE OWNED BY     =   ALTER SEQUENCE public.users_id_seq OWNED BY public.users.id;
          public          postgres    false    215         8           2604    18258 
   comment id    DEFAULT     h   ALTER TABLE ONLY public.comment ALTER COLUMN id SET DEFAULT nextval('public.comment_id_seq'::regclass);
 9   ALTER TABLE public.comment ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    223    224    224         6           2604    18179    home_tech id    DEFAULT     l   ALTER TABLE ONLY public.home_tech ALTER COLUMN id SET DEFAULT nextval('public.home_tech_id_seq'::regclass);
 ;   ALTER TABLE public.home_tech ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    219    220    220         7           2604    18239 
   request id    DEFAULT     h   ALTER TABLE ONLY public.request ALTER COLUMN id SET DEFAULT nextval('public.request_id_seq'::regclass);
 9   ALTER TABLE public.request ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    222    221    222         5           2604    18170    tech_type id    DEFAULT     l   ALTER TABLE ONLY public.tech_type ALTER COLUMN id SET DEFAULT nextval('public.tech_type_id_seq'::regclass);
 ;   ALTER TABLE public.tech_type ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    218    217    218         4           2604    18161    users id    DEFAULT     d   ALTER TABLE ONLY public.users ALTER COLUMN id SET DEFAULT nextval('public.users_id_seq'::regclass);
 7   ALTER TABLE public.users ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    216    215    216         �          0    18255    comment 
   TABLE DATA           ?   COPY public.comment (id, request, master, message) FROM stdin;
    public          postgres    false    224       4832.dat �          0    18176 	   home_tech 
   TABLE DATA           4   COPY public.home_tech (id, type, model) FROM stdin;
    public          postgres    false    220       4828.dat �          0    18236    request 
   TABLE DATA           s   COPY public.request (id, master, client, start_date, home_tech, problem_desc, status, completion_date) FROM stdin;
    public          postgres    false    222       4830.dat �          0    18167 	   tech_type 
   TABLE DATA           -   COPY public.tech_type (id, name) FROM stdin;
    public          postgres    false    218       4826.dat �          0    18158    users 
   TABLE DATA           F   COPY public.users (id, fio, phone, login, password, type) FROM stdin;
    public          postgres    false    216       4824.dat �           0    0    comment_id_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public.comment_id_seq', 5, true);
          public          postgres    false    223         �           0    0    home_tech_id_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.home_tech_id_seq', 11, true);
          public          postgres    false    219         �           0    0    request_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.request_id_seq', 11, true);
          public          postgres    false    221         �           0    0    tech_type_id_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.tech_type_id_seq', 5, true);
          public          postgres    false    217         �           0    0    users_id_seq    SEQUENCE SET     ;   SELECT pg_catalog.setval('public.users_id_seq', 10, true);
          public          postgres    false    215         B           2606    18262    comment comment_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.comment
    ADD CONSTRAINT comment_pkey PRIMARY KEY (id);
 >   ALTER TABLE ONLY public.comment DROP CONSTRAINT comment_pkey;
       public            postgres    false    224         >           2606    18183    home_tech home_tech_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.home_tech
    ADD CONSTRAINT home_tech_pkey PRIMARY KEY (id);
 B   ALTER TABLE ONLY public.home_tech DROP CONSTRAINT home_tech_pkey;
       public            postgres    false    220         @           2606    18243    request request_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.request
    ADD CONSTRAINT request_pkey PRIMARY KEY (id);
 >   ALTER TABLE ONLY public.request DROP CONSTRAINT request_pkey;
       public            postgres    false    222         <           2606    18174    tech_type tech_type_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.tech_type
    ADD CONSTRAINT tech_type_pkey PRIMARY KEY (id);
 B   ALTER TABLE ONLY public.tech_type DROP CONSTRAINT tech_type_pkey;
       public            postgres    false    218         :           2606    18165    users users_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.users DROP CONSTRAINT users_pkey;
       public            postgres    false    216         F           2606    18268    comment comment_master_fkey    FK CONSTRAINT     y   ALTER TABLE ONLY public.comment
    ADD CONSTRAINT comment_master_fkey FOREIGN KEY (master) REFERENCES public.users(id);
 E   ALTER TABLE ONLY public.comment DROP CONSTRAINT comment_master_fkey;
       public          postgres    false    4666    216    224         G           2606    18263    comment comment_request_fkey    FK CONSTRAINT     }   ALTER TABLE ONLY public.comment
    ADD CONSTRAINT comment_request_fkey FOREIGN KEY (request) REFERENCES public.request(id);
 F   ALTER TABLE ONLY public.comment DROP CONSTRAINT comment_request_fkey;
       public          postgres    false    224    4672    222         C           2606    18184    home_tech home_tech_type_fkey    FK CONSTRAINT     }   ALTER TABLE ONLY public.home_tech
    ADD CONSTRAINT home_tech_type_fkey FOREIGN KEY (type) REFERENCES public.tech_type(id);
 G   ALTER TABLE ONLY public.home_tech DROP CONSTRAINT home_tech_type_fkey;
       public          postgres    false    218    220    4668         D           2606    18244    request request_client_fkey    FK CONSTRAINT     y   ALTER TABLE ONLY public.request
    ADD CONSTRAINT request_client_fkey FOREIGN KEY (client) REFERENCES public.users(id);
 E   ALTER TABLE ONLY public.request DROP CONSTRAINT request_client_fkey;
       public          postgres    false    222    4666    216         E           2606    18249    request request_home_tech_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.request
    ADD CONSTRAINT request_home_tech_fkey FOREIGN KEY (home_tech) REFERENCES public.home_tech(id);
 H   ALTER TABLE ONLY public.request DROP CONSTRAINT request_home_tech_fkey;
       public          postgres    false    220    222    4670                                                                                                                                                                                                                 4832.dat                                                                                            0000600 0004000 0002000 00000000457 14765724220 0014271 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        1	1	2	Интересная поломка
2	2	3	Очень странно, будем разбираться!
3	7	2	Скорее всего потребуется мотор обдува!
4	1	2	Интересная поломка
5	6	3	Очень странно, будем разбираться!
\.


                                                                                                                                                                                                                 4828.dat                                                                                            0000600 0004000 0002000 00000000476 14765724220 0014277 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        2	2	Redmond RT-437 черный
3	3	Indesit DS 316 W белый
4	4	DEXP WM-F610NTMA/WW белый
5	5	Redmond RMC-M95 черный
6	1	Ладомир ТА113 чёрный
7	3	Indesit DS 314 W серый
8	1	Model 1
9	3	Модель 2
10	5	Модель 3
1	1	Ладомир ТА112 белый
11	3	Холодос
\.


                                                                                                                                                                                                  4830.dat                                                                                            0000600 0004000 0002000 00000001272 14765724220 0014263 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        2	3	7	2023-05-05	2	Перестал работать	в процессе ремонта	\N
3	2	8	2022-07-07	3	Не морозит одна из камер холодильника	готова к выдаче	2023-01-01
4	\N	8	2023-08-02	4	Перестали работать многие режимы стирки	новая	\N
5	\N	9	2023-08-02	5	Перестала включаться	новая	\N
6	2	7	2023-08-02	6	Перестал работать	готова к выдаче	2023-08-03
7	2	8	2023-07-09	7	Гудит, но не замораживает	готова к выдаче	2023-08-03
1	2	7	2023-03-31	1	Перестал работать	в процессе ремонта	\N
\.


                                                                                                                                                                                                                                                                                                                                      4826.dat                                                                                            0000600 0004000 0002000 00000000163 14765724220 0014266 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        1	Фен
2	Тостер
3	Холодильник
4	Стиральная машина
5	Мультиварка
\.


                                                                                                                                                                                                                                                                                                                                                                                                             4824.dat                                                                                            0000600 0004000 0002000 00000001615 14765724220 0014267 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        1	Трубин Никита Юрьевич	89210563128	kasoo	root	менеджер
2	Мурашов Андрей Юрьевич	89535078985	murashov123	qwerty	мастер
3	Степанов Андрей Викторович	89210673849	test1	test1	мастер
4	Перина Анастасия Денисовна	89990563748	perinaAD	250519	оператор
5	Мажитова Ксения Сергеевна	89994563847	krutiha1234567	1234567890	оператор
6	Семенова Ясмина Марковна	89994563847	login1	pass1	мастер
7	Баранова Эмилия Марковна	89994563841	login2	pass2	заказчик
8	Егорова Алиса Платоновна	89994563842	login3	pass3	заказчик
9	Титов Максим Иванович	89994563843	login4	pass4	заказчик
10	Иванов Марк Максимович	89994563844	login5	pass5	мастер
\.


                                                                                                                   restore.sql                                                                                         0000600 0004000 0002000 00000023757 14765724220 0015413 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        --
-- NOTE:
--
-- File paths need to be edited. Search for $$PATH$$ and
-- replace it with the path to the directory containing
-- the extracted data files.
--
--
-- PostgreSQL database dump
--

-- Dumped from database version 16.0
-- Dumped by pg_dump version 16.0

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

DROP DATABASE crm_demo;
--
-- Name: crm_demo; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE crm_demo WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';


ALTER DATABASE crm_demo OWNER TO postgres;

\connect crm_demo

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: request_status; Type: TYPE; Schema: public; Owner: postgres
--

CREATE TYPE public.request_status AS ENUM (
    'новая',
    'в процессе ремонта',
    'готова к выдаче'
);


ALTER TYPE public.request_status OWNER TO postgres;

--
-- Name: user_type; Type: TYPE; Schema: public; Owner: postgres
--

CREATE TYPE public.user_type AS ENUM (
    'заказчик',
    'мастер',
    'менеджер',
    'оператор'
);


ALTER TYPE public.user_type OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: comment; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.comment (
    id integer NOT NULL,
    request integer,
    master integer,
    message text NOT NULL
);


ALTER TABLE public.comment OWNER TO postgres;

--
-- Name: comment_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.comment_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.comment_id_seq OWNER TO postgres;

--
-- Name: comment_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.comment_id_seq OWNED BY public.comment.id;


--
-- Name: home_tech; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.home_tech (
    id integer NOT NULL,
    type integer,
    model text NOT NULL
);


ALTER TABLE public.home_tech OWNER TO postgres;

--
-- Name: home_tech_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.home_tech_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.home_tech_id_seq OWNER TO postgres;

--
-- Name: home_tech_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.home_tech_id_seq OWNED BY public.home_tech.id;


--
-- Name: request; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.request (
    id integer NOT NULL,
    master integer,
    client integer,
    start_date date NOT NULL,
    home_tech integer,
    problem_desc text NOT NULL,
    status public.request_status NOT NULL,
    completion_date date
);


ALTER TABLE public.request OWNER TO postgres;

--
-- Name: request_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.request_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.request_id_seq OWNER TO postgres;

--
-- Name: request_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.request_id_seq OWNED BY public.request.id;


--
-- Name: tech_type; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tech_type (
    id integer NOT NULL,
    name text NOT NULL
);


ALTER TABLE public.tech_type OWNER TO postgres;

--
-- Name: tech_type_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tech_type_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tech_type_id_seq OWNER TO postgres;

--
-- Name: tech_type_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tech_type_id_seq OWNED BY public.tech_type.id;


--
-- Name: users; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.users (
    id integer NOT NULL,
    fio text NOT NULL,
    phone text NOT NULL,
    login text NOT NULL,
    password text NOT NULL,
    type public.user_type NOT NULL
);


ALTER TABLE public.users OWNER TO postgres;

--
-- Name: users_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.users_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.users_id_seq OWNER TO postgres;

--
-- Name: users_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.users_id_seq OWNED BY public.users.id;


--
-- Name: comment id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.comment ALTER COLUMN id SET DEFAULT nextval('public.comment_id_seq'::regclass);


--
-- Name: home_tech id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.home_tech ALTER COLUMN id SET DEFAULT nextval('public.home_tech_id_seq'::regclass);


--
-- Name: request id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.request ALTER COLUMN id SET DEFAULT nextval('public.request_id_seq'::regclass);


--
-- Name: tech_type id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tech_type ALTER COLUMN id SET DEFAULT nextval('public.tech_type_id_seq'::regclass);


--
-- Name: users id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users ALTER COLUMN id SET DEFAULT nextval('public.users_id_seq'::regclass);


--
-- Data for Name: comment; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.comment (id, request, master, message) FROM stdin;
\.
COPY public.comment (id, request, master, message) FROM '$$PATH$$/4832.dat';

--
-- Data for Name: home_tech; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.home_tech (id, type, model) FROM stdin;
\.
COPY public.home_tech (id, type, model) FROM '$$PATH$$/4828.dat';

--
-- Data for Name: request; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.request (id, master, client, start_date, home_tech, problem_desc, status, completion_date) FROM stdin;
\.
COPY public.request (id, master, client, start_date, home_tech, problem_desc, status, completion_date) FROM '$$PATH$$/4830.dat';

--
-- Data for Name: tech_type; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tech_type (id, name) FROM stdin;
\.
COPY public.tech_type (id, name) FROM '$$PATH$$/4826.dat';

--
-- Data for Name: users; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.users (id, fio, phone, login, password, type) FROM stdin;
\.
COPY public.users (id, fio, phone, login, password, type) FROM '$$PATH$$/4824.dat';

--
-- Name: comment_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.comment_id_seq', 5, true);


--
-- Name: home_tech_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.home_tech_id_seq', 11, true);


--
-- Name: request_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.request_id_seq', 11, true);


--
-- Name: tech_type_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tech_type_id_seq', 5, true);


--
-- Name: users_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.users_id_seq', 10, true);


--
-- Name: comment comment_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.comment
    ADD CONSTRAINT comment_pkey PRIMARY KEY (id);


--
-- Name: home_tech home_tech_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.home_tech
    ADD CONSTRAINT home_tech_pkey PRIMARY KEY (id);


--
-- Name: request request_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.request
    ADD CONSTRAINT request_pkey PRIMARY KEY (id);


--
-- Name: tech_type tech_type_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tech_type
    ADD CONSTRAINT tech_type_pkey PRIMARY KEY (id);


--
-- Name: users users_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_pkey PRIMARY KEY (id);


--
-- Name: comment comment_master_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.comment
    ADD CONSTRAINT comment_master_fkey FOREIGN KEY (master) REFERENCES public.users(id);


--
-- Name: comment comment_request_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.comment
    ADD CONSTRAINT comment_request_fkey FOREIGN KEY (request) REFERENCES public.request(id);


--
-- Name: home_tech home_tech_type_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.home_tech
    ADD CONSTRAINT home_tech_type_fkey FOREIGN KEY (type) REFERENCES public.tech_type(id);


--
-- Name: request request_client_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.request
    ADD CONSTRAINT request_client_fkey FOREIGN KEY (client) REFERENCES public.users(id);


--
-- Name: request request_home_tech_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.request
    ADD CONSTRAINT request_home_tech_fkey FOREIGN KEY (home_tech) REFERENCES public.home_tech(id);


--
-- PostgreSQL database dump complete
--

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 