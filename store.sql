--
-- PostgreSQL database dump
--

-- Dumped from database version 13.3
-- Dumped by pg_dump version 14.0

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

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: OrderItem; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."OrderItem" (
    "Id" uuid NOT NULL,
    "Name" text,
    "Price" numeric(18,2) NOT NULL,
    "Quantity" numeric(18,2) NOT NULL,
    "Discount" numeric(18,2) NOT NULL,
    "MaxDiscount" numeric(18,2) NOT NULL,
    "Total" numeric(18,2) NOT NULL,
    "ProductId" uuid NOT NULL,
    "OrderId" uuid NOT NULL,
    "Created" timestamp without time zone NOT NULL,
    "LastModified" timestamp without time zone NOT NULL
);


ALTER TABLE public."OrderItem" OWNER TO postgres;

--
-- Name: Orders; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Orders" (
    "Id" uuid NOT NULL,
    "Value" numeric(18,2) NOT NULL,
    "Created" timestamp without time zone NOT NULL,
    "LastModified" timestamp without time zone NOT NULL
);


ALTER TABLE public."Orders" OWNER TO postgres;

--
-- Name: Products; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Products" (
    "Id" uuid NOT NULL,
    "Code" bigint NOT NULL,
    "Name" character varying(90) NOT NULL,
    "Description" character varying(120) NOT NULL,
    "Stock" numeric(18,2) NOT NULL,
    "StockMin" numeric(18,2) NOT NULL,
    "PurchasePrice" numeric(10,2) NOT NULL,
    "Price" numeric(18,2) NOT NULL,
    "MaxDiscount" numeric(10,2) NOT NULL,
    "Created" timestamp without time zone NOT NULL,
    "LastModified" timestamp without time zone NOT NULL
);


ALTER TABLE public."Products" OWNER TO postgres;

--
-- Data for Name: OrderItem; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."OrderItem" ("Id", "Name", "Price", "Quantity", "Discount", "MaxDiscount", "Total", "ProductId", "OrderId", "Created", "LastModified") FROM stdin;
006a8418-b2cd-4951-8773-e830abfb755a	maiô preto 	101.25	1.00	10.00	0.00	101.25	36a1720d-54df-4661-a04b-b3cb54e6c208	17005b62-155d-4c2d-a6c1-29d67b5b83f0	2021-09-27 15:59:35.18164	-infinity
0642c1e7-7f5a-40fe-9a99-2b2ca2cfe1eb	carregador cel/carro carregador cel/carro	15.00	1.00	0.00	10.00	15.00	2a6d2ea5-14a5-4f30-8373-61a63308a915	e0619763-2d0f-492d-8a45-432c9f720f4a	2021-10-07 11:49:36.722047	-infinity
0d04d724-1f14-4cb6-90a3-4feaf6605ac8	short 	25.20	1.00	28.00	0.00	25.20	070744b1-a86c-4d32-9ac4-a29added8931	774ca41a-2fea-4a57-a738-9c08f958eb3e	2021-09-29 13:22:16.244346	-infinity
161e7d82-25aa-448d-82ce-96f54b55bedf	\N	10.80	1.00	10.00	0.00	10.80	0f608da1-1a89-41e0-a66a-4c765f19207d	dc97a732-0474-40af-ac3c-4f761ad69995	2021-09-22 17:37:52.141724	-infinity
18ebd17c-7876-4642-a5ea-1883de8346ba	chapéu  	40.41	1.00	10.00	0.00	40.41	1c27ab96-9e3f-460d-8d0e-4d68d2c4f9af	d4bd298b-ebdb-4aa2-becb-c4cecf1c9c8e	2021-10-18 14:29:41.150932	-infinity
23fb811a-f314-4304-907d-2ff9df094606	cintura alta abeta com laço 	90.00	1.00	0.00	0.00	90.00	07e00153-d492-4df4-b76e-6a10832aaa34	8f78043d-e706-4218-bc91-7cbadcd456ca	2021-10-23 12:46:58.531802	-infinity
2d8e8bab-c5ee-4c71-af33-a4fe6ab75f40	artesanatos P artesanatos P	9.00	1.00	10.00	0.00	9.00	382574c6-a07d-4ffb-854c-1e7a8d5863b0	c539dc7f-3ddf-401b-acff-05380d764aa0	2021-09-29 13:24:55.823298	-infinity
34766b10-411a-4b07-af50-5378336dc5ec	maiô cropped com viés 	107.55	1.00	10.00	0.00	107.55	dfd2d613-5886-49e8-b8d3-968624c6a802	2b1dc5c1-a569-4557-b6f6-2cc995e9b34e	2021-09-24 16:20:49.515705	-infinity
37c7fe7a-2531-4ccf-9ae1-bacf166a85d4	protetor sundown 30 fps kids protetor sundown 30 fps kids	50.00	1.00	0.00	10.00	50.00	81e8a056-072e-49a9-af05-94e259f4a211	beadf668-9306-44ef-8ffa-5c60191976d9	2021-09-26 12:51:43.820911	-infinity
3fdc6d83-1a4c-4860-b73d-b3b214446fd5	ARTESNATO 	15.90	1.00	0.00	0.00	15.90	17b9f461-5ad7-45aa-a243-4ddbed29c7ee	7df07fc9-e261-4849-acbd-1b0366df7568	2021-09-24 12:58:28.656001	-infinity
44a2c936-f54a-4e59-9471-39ce94329ce6	biquini calça franzida biquini calça franzida	100.80	1.00	4.00	0.00	100.80	86c678a8-c995-4b2f-ac22-1ce4e21c0054	b8993cf8-f58c-47b8-b8ac-6a0822c5c773	2021-10-22 12:29:25.030892	-infinity
4559a866-5455-40bd-be4c-2395bfed5127	genai pagamento; 100,00	100.00	1.00	0.00	0.00	100.00	f27e28bc-3881-4485-b70e-dc4988355761	d1a81b02-092e-45fa-b4d5-a30f2dd79dc3	2021-10-07 11:43:56.306938	-infinity
50628145-b61b-4fb0-b077-39a820380d01	\N	89.91	1.00	10.00	0.00	89.91	728633ae-49ef-486d-ba64-8fd473a3cf75	ab66ecd3-a314-40a0-a38e-d583c4926add	2021-09-19 19:57:39.65683	-infinity
52365eda-7169-4e73-9d3c-d0790b765a54	maiô com amarração 	105.00	1.00	0.00	0.00	105.00	18562d8c-c7af-42d2-8758-96e7e0cfe9f4	ec0047e0-bc33-43be-ad99-d37176c8fb85	2021-10-16 13:23:58.813979	-infinity
5c60c7ef-2001-4a8a-93a8-74b76b9f2312	artesanatos P 	10.00	3.00	0.00	0.00	30.00	382574c6-a07d-4ffb-854c-1e7a8d5863b0	7df07fc9-e261-4849-acbd-1b0366df7568	2021-09-24 12:58:28.656001	-infinity
5ee0afa2-c0d4-4d7b-92f0-65b7286e972a	sunga adulto sunga adulto	35.20	1.00	12.00	10.00	35.20	35ebeaaf-2c9e-47b7-b550-4a3d6d0ef371	d0c10976-9190-4b44-a426-6cda68aa3cf4	2021-10-01 16:26:07.10295	-infinity
5fecd655-066e-4626-b097-e9f4a6e719f6	camisa uv 	50.00	2.00	16.52	0.00	100.01	1e3f12ef-75fb-4283-8ea9-2d13f5b8f1a2	00ec2ce1-cafd-4917-b29b-456e2777fcc2	2021-09-23 19:01:33.231236	-infinity
726a47a6-05c8-4fc5-8979-974ce4aa5bfd	\N	89.91	1.00	10.00	0.00	89.91	fdbd1d66-658e-4cd7-b444-70eb0add4f93	1d853422-b07d-41da-b9a5-ff8b18be0ae1	2021-09-19 19:37:08.108457	-infinity
7cc1e8e1-bd83-4b9a-9512-d3d69416dfb9	camisa uv camisa uv	50.32	1.00	16.00	10.00	50.32	1e3f12ef-75fb-4283-8ea9-2d13f5b8f1a2	8f78043d-e706-4218-bc91-7cbadcd456ca	2021-10-23 12:46:58.531801	-infinity
84290a6c-9172-45b6-aba0-0e3e8185a5c1	sunga adulto sunga adulto	35.60	1.00	11.00	10.00	35.60	35ebeaaf-2c9e-47b7-b550-4a3d6d0ef371	413cabc3-fd5a-4584-b136-4a161853f737	2021-10-04 17:37:57.470236	-infinity
87147a81-ce4f-430b-8c55-6e534a86b35c	chapeu quarto 13	44.90	1.00	0.00	0.00	44.90	7f67a47b-981f-4d13-91d5-1b90252519d0	e0619763-2d0f-492d-8a45-432c9f720f4a	2021-10-07 11:49:36.722046	-infinity
8fd2fd99-8205-45a1-a598-82090ad05254	Chapeu	25.11	5.00	10.00	0.00	125.55	d76780d5-ae2e-4857-a77b-1d5f31fe0607	4ef0891a-e521-4fe6-a934-dfdac0f6ac0e	2021-09-22 19:29:16.451111	-infinity
909912e0-31ee-41c6-8129-f3713000c963	saída azul 	79.00	1.00	0.00	0.00	79.00	ae570c4b-4c6a-4e93-9066-94b03f231f8a	774ca41a-2fea-4a57-a738-9c08f958eb3e	2021-09-29 13:22:16.244346	-infinity
9a93df09-6a97-46c7-8d29-aef0d2ec7bd5	\N	89.91	1.00	10.00	0.00	89.91	7b8d4022-346d-4d29-a064-9a5f983a4555	f6409f64-ad41-447e-93a7-9e0b4b786e65	2021-09-19 19:40:23.359311	-infinity
9c8d44a1-a49a-4ba9-8ef6-9a1d110c25b1	namoradeira p namoradeira p	13.50	1.00	10.00	0.00	13.50	dbfd6865-2a16-4577-8a5c-d856112d3cf5	c539dc7f-3ddf-401b-acff-05380d764aa0	2021-09-29 13:24:55.823298	-infinity
a2add402-f6f1-4b31-b604-580a8c5cebf6	protetor sundown 50 fps 	81.00	1.00	10.00	0.00	81.00	8e16d468-024d-4421-b010-4217bdc77ef1	413cabc3-fd5a-4584-b136-4a161853f737	2021-10-04 17:37:57.470236	-infinity
ac58bf53-a896-48c5-bf30-d7ffdf9f0692	maiô estampado 	88.20	1.00	10.00	0.00	88.20	e3487a05-e08f-450b-97a8-86e684fe61e8	17005b62-155d-4c2d-a6c1-29d67b5b83f0	2021-09-27 15:59:35.18164	-infinity
b31e2e9a-c63c-4360-885d-af0df0e4c981	carregador cel/carro 	13.50	1.00	10.00	0.00	13.50	2a6d2ea5-14a5-4f30-8373-61a63308a915	17005b62-155d-4c2d-a6c1-29d67b5b83f0	2021-09-27 15:59:35.18164	-infinity
b6898dcf-c61c-4a40-ae9b-e96ec8854cc9	saída maitê saída maitê	81.00	1.00	0.00	0.00	81.00	a1735fb9-a1c6-4524-9b09-6a532f2845f9	aee43c7d-ab35-4a04-bde5-7f9c2281af98	2021-10-13 12:47:29.742892	-infinity
b8bb36bb-6d2a-4d57-ba18-6fd438c3d9e3	chapéu  	40.41	1.00	10.00	0.00	40.41	1c27ab96-9e3f-460d-8d0e-4d68d2c4f9af	0c39a8a3-6f2b-4468-8611-89b2b33ca857	2021-10-23 11:53:23.461304	-infinity
bbe9726a-2cc2-4db9-9eaf-ecf5a1174d5f	bolsa estampada bolsa estampada	44.41	1.00	11.00	0.00	44.41	3cf653a2-43b2-414d-a0cb-3bba7c0fa7bf	3e6f7b00-f4f0-496f-b420-3db20e371f94	2021-10-02 13:44:30.347772	-infinity
c336ecfc-e196-4ec6-8d83-bca1f57c607e	carregador/ cell e carro 	13.50	1.00	10.00	0.00	13.50	2a6d2ea5-14a5-4f30-8373-61a63308a915	9374a934-0bf1-4494-af6a-95ef08fb5517	2021-09-23 18:56:32.508674	-infinity
c96c648f-f865-4542-a24b-80c1443a3ecf	protetor sundown 30 fps kids 	45.00	1.00	10.00	0.00	45.00	81e8a056-072e-49a9-af05-94e259f4a211	9374a934-0bf1-4494-af6a-95ef08fb5517	2021-09-23 18:56:32.508674	-infinity
ce946be3-eb26-4753-aa3c-b8af7bdfcf3a	saida gg saida gg	99.00	1.00	0.00	0.00	99.00	719b998d-f9fe-4a87-83e6-b6b7f4a4a06b	ec0047e0-bc33-43be-ad99-d37176c8fb85	2021-10-16 13:23:58.813979	-infinity
defe66af-e15a-47b6-82ca-7d413c6710dc	chapéu  chapéu 	44.90	1.00	0.00	10.00	44.90	1c27ab96-9e3f-460d-8d0e-4d68d2c4f9af	aee43c7d-ab35-4a04-bde5-7f9c2281af98	2021-10-13 12:47:29.742892	-infinity
efadc5ed-c081-4d4e-86be-46db2a35d591	short gg 	39.60	1.00	10.00	0.00	39.60	2edc486d-88fe-4087-8069-4d458f4a884b	d4bd298b-ebdb-4aa2-becb-c4cecf1c9c8e	2021-10-18 14:29:41.150908	-infinity
f358e541-e826-4b45-88ff-54f3ca3d8b2c	\N	89.91	1.00	10.00	0.00	89.91	728633ae-49ef-486d-ba64-8fd473a3cf75	6b6efb00-5326-4f53-a423-605e12ef8d4a	2021-09-22 17:01:31.280895	-infinity
f385adb0-0e47-4e72-acf8-a0b012af8d12	ARTESNATO ARTESNATO	14.31	2.00	10.00	0.00	28.62	17b9f461-5ad7-45aa-a243-4ddbed29c7ee	c539dc7f-3ddf-401b-acff-05380d764aa0	2021-09-29 13:24:55.823298	-infinity
fc7a8e1f-da08-4b20-8aec-009515859e5e	bermuda masc 	36.00	2.00	10.00	0.00	72.00	b020750a-4d89-4652-928e-fe1c82e4f091	9374a934-0bf1-4494-af6a-95ef08fb5517	2021-09-23 18:56:32.508673	-infinity
fd9e7dd5-95c2-452f-88ef-f0e5438ba354	biquini calça franzida na lateral 	75.60	1.00	10.00	0.00	75.60	e8d1e362-9a4e-4cad-8534-8492ce91f1c0	9374a934-0bf1-4494-af6a-95ef08fb5517	2021-09-23 18:56:32.508673	-infinity
ff0cb5a8-dbae-4019-b678-710e25e3d219	imã/ chaveiro imã/ chaveiro	5.00	1.00	0.00	0.00	5.00	92539caf-cfab-4850-aed9-1e4f13f949c7	413cabc3-fd5a-4584-b136-4a161853f737	2021-10-04 17:37:57.470237	-infinity
\.


--
-- Data for Name: Orders; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Orders" ("Id", "Value", "Created", "LastModified") FROM stdin;
00ec2ce1-cafd-4917-b29b-456e2777fcc2	100.01	2021-09-23 19:01:33.231236	-infinity
0c39a8a3-6f2b-4468-8611-89b2b33ca857	40.41	2021-10-23 11:53:23.461303	-infinity
17005b62-155d-4c2d-a6c1-29d67b5b83f0	202.95	2021-09-27 15:59:35.181639	-infinity
1d853422-b07d-41da-b9a5-ff8b18be0ae1	89.91	2021-09-19 19:37:08.108433	-infinity
2b1dc5c1-a569-4557-b6f6-2cc995e9b34e	107.55	2021-09-24 16:20:49.515705	-infinity
3e6f7b00-f4f0-496f-b420-3db20e371f94	44.41	2021-10-02 13:44:30.347771	-infinity
413cabc3-fd5a-4584-b136-4a161853f737	121.60	2021-10-04 17:37:57.470235	-infinity
4ef0891a-e521-4fe6-a934-dfdac0f6ac0e	125.55	2021-09-22 19:29:16.451089	-infinity
6b6efb00-5326-4f53-a423-605e12ef8d4a	89.91	2021-09-22 17:01:31.280869	-infinity
774ca41a-2fea-4a57-a738-9c08f958eb3e	104.20	2021-09-29 13:22:16.244345	-infinity
7df07fc9-e261-4849-acbd-1b0366df7568	45.90	2021-09-24 12:58:28.656	-infinity
8f78043d-e706-4218-bc91-7cbadcd456ca	140.32	2021-10-23 12:46:58.53168	-infinity
9374a934-0bf1-4494-af6a-95ef08fb5517	206.10	2021-09-23 18:56:32.508672	-infinity
ab66ecd3-a314-40a0-a38e-d583c4926add	89.91	2021-09-19 19:57:39.656804	-infinity
aee43c7d-ab35-4a04-bde5-7f9c2281af98	125.90	2021-10-13 12:47:29.742891	-infinity
b8993cf8-f58c-47b8-b8ac-6a0822c5c773	100.80	2021-10-22 12:29:25.030891	-infinity
beadf668-9306-44ef-8ffa-5c60191976d9	50.00	2021-09-26 12:51:43.82091	-infinity
c539dc7f-3ddf-401b-acff-05380d764aa0	51.12	2021-09-29 13:24:55.823296	-infinity
d0c10976-9190-4b44-a426-6cda68aa3cf4	35.20	2021-10-01 16:26:07.10295	-infinity
d1a81b02-092e-45fa-b4d5-a30f2dd79dc3	100.00	2021-10-07 11:43:56.306937	-infinity
d4bd298b-ebdb-4aa2-becb-c4cecf1c9c8e	80.01	2021-10-18 14:29:41.150906	-infinity
dc97a732-0474-40af-ac3c-4f761ad69995	10.80	2021-09-22 17:37:52.141701	-infinity
e0619763-2d0f-492d-8a45-432c9f720f4a	59.90	2021-10-07 11:49:36.722046	-infinity
ec0047e0-bc33-43be-ad99-d37176c8fb85	204.00	2021-10-16 13:23:58.813979	-infinity
f6409f64-ad41-447e-93a7-9e0b4b786e65	89.91	2021-09-19 19:40:23.359309	-infinity
\.


--
-- Data for Name: Products; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Products" ("Id", "Code", "Name", "Description", "Stock", "StockMin", "PurchasePrice", "Price", "MaxDiscount", "Created", "LastModified") FROM stdin;
2da515ac-e09c-4b9a-82af-47dd7ae92819	8	Namoradeira	Pequena	4.00	2.00	12.00	24.90	10.00	2021-10-24 18:09:26.974828	2021-10-24 18:09:26.974828
47f115fa-601e-41a3-97f9-977f334cc56c	5	Saída de Praia		4.00	2.00	33.00	78.90	10.00	2021-10-24 18:09:26.974827	2021-10-24 18:09:26.974827
4fdd650e-f804-47f5-bd7d-de23e4b512e9	1	Biquine		4.00	2.00	38.90	99.90	10.00	2021-10-24 18:09:26.974825	2021-10-24 18:09:26.974825
5a1bf5b4-4dde-4c62-83ca-2e52b3733b2b	2	Boné Nike	Preto	5.00	3.00	24.90	12.00	10.00	2021-10-24 18:09:26.974826	2021-10-24 18:09:26.974826
6db73648-93be-486f-9993-1fd387bcac24	10	UV	M	18.00	10.00	23.00	59.90	10.00	2021-10-24 18:09:26.974828	2021-10-24 18:09:26.974828
841add37-bbff-4132-8318-3ce5d42a580c	6	Canga		4.00	2.00	40.00	99.90	10.00	2021-10-24 18:09:26.974827	2021-10-24 18:09:26.974827
9e054d19-9d96-4b6f-ab82-2d3dcc618d26	3	Snorkel		8.00	4.00	29.90	14.00	10.00	2021-10-24 18:09:26.974826	2021-10-24 18:09:26.974826
cc958076-f5ac-4538-9723-2d93f3685052	4	Chapeu		4.00	2.00	12.00	27.90	10.00	2021-10-24 18:09:26.974827	2021-10-24 18:09:26.974827
d4307777-6174-4834-83ee-61122fcc3616	7	Óculos'		10.00	5.00	8.00	19.90	10.00	2021-10-24 18:09:26.974828	2021-10-24 18:09:26.974828
d7c00595-b83d-4e66-9faa-816a56f7e082	9	Sunga	M	10.00	4.00	17.00	29.90	10.00	2021-10-24 18:09:26.974828	2021-10-24 18:09:26.974828
0421f3eb-a6f0-4363-b7ea-826f363b7bd7	9046	biquni curtininha (4 rabo)		0.00	0.00	42.00	105.00	0.00	2021-10-13 11:54:15.067797	-infinity
070744b1-a86c-4d32-9ac4-a29added8931	31	short		-1.00	0.00	0.00	35.00	0.00	2021-09-29 13:21:01.177688	2021-09-29 13:22:16.244347
07e00153-d492-4df4-b76e-6a10832aaa34	295	cintura alta abeta com laço		-1.00	0.00	36.00	90.00	0.00	2021-10-13 11:40:09.256462	2021-10-23 12:46:58.531803
0b855ec3-296a-44d1-b6ae-53203b1bd39b	156	biquini ingrid		0.00	0.00	0.00	96.00	10.00	2021-09-23 18:12:06.028786	-infinity
0c7e85fd-61cf-4e6b-89f0-eac8b9557efd	9016	maiô peitao bojo com babado		0.00	0.00	0.00	129.00	10.00	2021-09-23 18:11:39.065431	-infinity
17b9f461-5ad7-45aa-a243-4ddbed29c7ee	19	ARTESNATO		-3.00	0.00	0.00	15.90	0.00	2021-09-24 12:56:16.62741	2021-09-29 13:24:55.823321
18562d8c-c7af-42d2-8758-96e7e0cfe9f4	3370	maiô com amarração		-1.00	0.00	42.00	105.00	0.00	2021-10-16 13:23:39.60261	2021-10-16 13:23:58.81398
18e92eee-c9b8-4473-9b4e-272847559cb7	1082	saída beatriz		0.00	0.00	0.00	81.00	0.00	2021-10-13 11:26:11.362182	-infinity
1bbb94cd-1b5e-4915-976e-5bfc6cf853ee	7	protetor cenoura e bronze 50 fps		0.00	0.00	0.00	60.00	10.00	2021-09-23 18:28:01.122399	-infinity
1bd4c24e-c928-4f2d-aae7-997ac7ef6fc4	11	snorkel		0.00	0.00	0.00	50.00	0.00	2021-09-23 18:30:34.367049	-infinity
1c27ab96-9e3f-460d-8d0e-4d68d2c4f9af	3	chapéu 		-8.00	0.00	0.00	44.90	10.00	2021-09-23 18:24:39.025932	2021-10-23 11:53:23.461304
1e3f12ef-75fb-4283-8ea9-2d13f5b8f1a2	1	camisa uv		-3.00	0.00	0.00	59.90	10.00	2021-09-23 18:23:43.210582	2021-10-23 12:46:58.531803
20000cb4-f72b-4658-b187-7bc606c54593	4	boné		0.00	0.00	0.00	29.90	10.00	2021-09-23 18:24:51.915945	-infinity
2a6d2ea5-14a5-4f30-8373-61a63308a915	17	carregador cel/carro		-13.00	0.00	0.00	15.00	10.00	-infinity	2021-10-07 11:49:36.722047
2e8b4dba-c013-41d8-8302-b623e7fc8d7b	12	óculos inf		0.00	0.00	0.00	15.00	0.00	2021-09-23 18:30:45.724646	-infinity
2edc486d-88fe-4087-8069-4d458f4a884b	440	short gg		-3.00	0.00	0.00	44.00	0.00	2021-10-18 14:23:25.004066	2021-10-18 14:29:41.150932
2f868597-3540-442d-a0d9-2581aab04cbc	20	namoradeira G		0.00	0.00	0.00	20.00	0.00	2021-09-24 12:56:30.164313	-infinity
349eef79-cb82-467c-9e03-9c113f0de7d8	55	short com cós		0.00	0.00	0.00	40.00	10.00	2021-09-23 18:08:04.457365	-infinity
35ebeaaf-2c9e-47b7-b550-4a3d6d0ef371	8	sunga adulto		-3.00	0.00	0.00	40.00	10.00	2021-09-23 18:19:03.823416	2021-10-04 17:37:57.470237
36a1720d-54df-4661-a04b-b3cb54e6c208	23	maiô preto		-6.00	0.00	0.00	112.50	0.00	2021-09-25 12:52:09.010759	2021-09-27 15:59:35.181642
37dd1eda-9374-4479-b375-a5bd903fc996	337	biquini gringo		0.00	0.00	0.00	80.00	10.00	2021-09-23 17:45:21.540539	-infinity
382574c6-a07d-4ffb-854c-1e7a8d5863b0	18	artesanatos P		-4.00	0.00	0.00	10.00	0.00	2021-09-24 12:56:01.596623	2021-09-29 13:24:55.823299
3cf653a2-43b2-414d-a0cb-3bba7c0fa7bf	16	bolsa estampada		-1.00	0.00	0.00	49.90	0.00	2021-09-23 18:32:43.273884	2021-10-02 13:44:30.347772
3fac5486-d452-4ae8-89ce-4bd98aab6fe9	9	namoradeira G		0.00	0.00	0.00	20.00	10.00	-infinity	2021-09-23 18:30:00.235425
4497386b-6e14-47a1-a066-8fed84680158	5004	biquini bojo curtininha		0.00	0.00	0.00	89.50	10.00	-infinity	2021-09-23 18:01:17.97422
4a577666-af2d-412b-b51d-889899e7411c	35	sunga inf		0.00	0.00	0.00	40.00	0.00	2021-09-23 18:20:06.344742	-infinity
4b5d0697-fa25-48af-8591-c4dd3790bb0d	1251	biquini busto transpassado		-2.00	0.00	0.00	84.00	10.00	2021-09-23 17:53:53.546198	2021-09-23 18:43:23.070815
4ca75bd0-3f04-41bc-9ecb-16d638f767b1	831	maiô com elastico grosso		0.00	0.00	0.00	112.50	10.00	2021-09-23 18:10:53.740538	-infinity
5466dbc1-1207-48aa-b160-f65ba14dcf69	55	canga de praia		0.00	0.00	0.00	75.00	10.00	2021-09-23 17:51:37.707473	-infinity
57a55633-da99-4a1f-add4-1fae7e1f68c3	90124	maio de bojo babado		0.00	0.00	0.00	112.50	10.00	2021-09-23 18:13:40.884193	-infinity
599690bb-c4b0-4ba3-a535-56db37d54dab	90191	biquini calça franzida		0.00	0.00	0.00	89.50	10.00	2021-09-23 18:00:16.918839	-infinity
5fd8e147-a61c-43fc-911b-99083f161a16	1214	biquini		0.00	0.00	0.00	69.90	10.00	2021-09-23 18:01:54.624575	-infinity
627aeea7-ba67-4fc8-a60f-e2d9b8cc20ff	9012	biquini fernanda		0.00	0.00	57.00	125.00	0.00	2021-10-13 11:53:03.414189	-infinity
65052f48-f556-49cd-835a-9a162591815e	9012	biquini fernanda gg		0.00	0.00	57.00	142.50	0.00	2021-10-13 11:38:27.536805	-infinity
67546f5c-6da9-436b-9412-4eb918c0ff65	342	biquini larissa		0.00	0.00	0.00	105.00	0.00	-infinity	2021-09-23 17:47:29.739747
6d5ce561-2498-4ae8-ab16-9931206b6f55	1080	saída beatriz		0.00	0.00	26.00	81.00	0.00	2021-10-13 11:28:30.002796	-infinity
719b998d-f9fe-4a87-83e6-b6b7f4a4a06b	139	saida gg		-1.00	0.00	0.00	99.00	0.00	2021-09-23 18:16:46.563109	2021-10-16 13:23:58.81398
7f67a47b-981f-4d13-91d5-1b90252519d0	101	chapeu	quarto 13	-1.00	0.00	0.00	44.90	0.00	2021-10-07 11:49:14.408775	2021-10-07 11:49:36.722047
8086114f-4417-4fe1-9805-e0e9404a846d	420	maiô cintura alta		0.00	0.00	0.00	94.50	10.00	2021-09-23 17:48:44.603154	-infinity
81e8a056-072e-49a9-af05-94e259f4a211	6	protetor sundown 30 fps kids		-6.00	0.00	0.00	50.00	10.00	2021-09-23 18:27:35.851672	2021-09-26 12:51:43.820911
86c678a8-c995-4b2f-ac22-1ce4e21c0054	90191	biquini calça franzida		-1.00	0.00	42.00	105.00	0.00	2021-10-13 11:54:56.524518	2021-10-22 12:29:25.030893
8e16d468-024d-4421-b010-4217bdc77ef1	5	protetor sundown 50 fps		-2.00	0.00	0.00	90.00	10.00	2021-09-23 18:27:11.175298	2021-10-04 17:37:57.470237
92539caf-cfab-4850-aed9-1e4f13f949c7	14	imã/ chaveiro		-2.00	0.00	0.00	5.00	0.00	2021-09-23 18:31:57.90623	2021-10-04 17:37:57.470238
92ace094-68ca-4451-832a-9094b091b531	90287	maio fechado com faixa		0.00	0.00	0.00	98.00	10.00	2021-09-23 18:14:27.535433	-infinity
959eb348-229e-40d3-8b59-eac11daebb3e	53	shortinho praia		0.00	0.00	0.00	30.00	10.00	2021-09-23 18:05:21.898683	-infinity
97e54165-274f-480b-8f17-6a679defcd0a	507	biquini decote v		0.00	0.00	0.00	99.90	0.00	2021-09-23 18:12:28.138053	-infinity
a0e34a02-0b53-4bae-8258-29f75abe2f11	1200	maiô fio com argola		0.00	0.00	0.00	90.00	0.00	2021-09-23 17:49:11.302611	-infinity
a1735fb9-a1c6-4524-9b09-6a532f2845f9	1082	saída maitê		-1.00	0.00	27.00	81.00	0.00	2021-10-13 12:43:55.629505	2021-10-13 12:47:29.742893
a1b303db-59c3-49ea-906e-0324f7efa9cc	280	biquini alça com tira		0.00	0.00	35.00	87.50	0.00	2021-10-13 11:40:46.177264	-infinity
a2e33c58-9030-4143-a902-e6c80d6438c2	15	bolsa amo o verão		0.00	0.00	0.00	74.90	0.00	2021-09-23 18:32:25.57296	-infinity
ae570c4b-4c6a-4e93-9066-94b03f231f8a	30	saída azul		-2.00	0.00	0.00	79.00	0.00	2021-09-29 13:20:52.028201	2021-09-29 13:22:16.244347
b020750a-4d89-4652-928e-fe1c82e4f091	2	bermuda masc		0.00	0.00	0.00	40.00	10.00	-infinity	2021-09-24 12:57:42.040484
b9601f35-d2a0-45f6-a975-f4d08f717241	22	maiô estampado		0.00	0.00	0.00	98.00	0.00	2021-09-25 12:54:54.927833	-infinity
bd1f0ac3-d30b-47f5-98c8-d175f91ccc4a	1233	maiô laço com cinto		0.00	0.00	0.00	112.50	10.00	2021-09-23 18:07:30.289387	-infinity
c144e47b-ab73-4760-8bca-8dd36d73d2d5	10	namoradeira P		0.00	0.00	0.00	15.00	0.00	2021-09-23 18:30:16.625541	-infinity
ce7afe96-2898-48a1-b84c-d5ccd6553ec8	90204	biquini top com laço		0.00	0.00	53.00	132.50	0.00	2021-10-13 11:55:32.860136	-infinity
d628f453-664a-4313-a7aa-f9650f8652f9	138	saida curta aberta		0.00	0.00	0.00	85.50	10.00	2021-09-23 18:15:28.314673	-infinity
dbfd6865-2a16-4577-8a5c-d856112d3cf5	21	namoradeira p		-1.00	0.00	0.00	15.00	0.00	2021-09-24 12:56:40.478877	2021-09-29 13:24:55.823322
dfd2d613-5886-49e8-b8d3-968624c6a802	90183	maiô cropped com viés		-3.00	0.00	0.00	119.50	10.00	2021-09-23 17:58:40.750592	2021-09-24 16:20:49.515706
e3487a05-e08f-450b-97a8-86e684fe61e8	22	maiô estampado		-6.00	0.00	0.00	98.00	0.00	2021-09-25 12:51:55.237294	2021-09-27 15:59:35.181642
e775d669-d2a3-4871-9931-89bb89c3c0b7	13	kit pitú		0.00	0.00	0.00	60.00	0.00	2021-09-23 18:31:39.713226	-infinity
e8d1e362-9a4e-4cad-8534-8492ce91f1c0	1254	biquini calça franzida na lateral		-5.00	0.00	0.00	84.00	10.00	2021-09-23 17:45:58.239275	2021-09-23 18:56:32.508674
eb8318d1-b7e6-4865-9644-c670c7e03848	1098	top com trança		0.00	0.00	36.00	90.00	0.00	2021-10-13 11:39:28.801743	-infinity
ee1a9c2c-afa1-43e3-abc9-2cd1eaaa1b24	257	biquini meio fio		0.00	0.00	0.00	79.00	10.00	2021-09-23 18:03:09.326075	-infinity
f27e28bc-3881-4485-b70e-dc4988355761	100	genai	pagamento; 100,00	-1.00	0.00	0.00	100.00	0.00	2021-10-07 11:43:38.417077	2021-10-07 11:43:56.306938
f6b456ee-4ea7-4eb2-b6aa-5e8c66908715	13	baldinho		0.00	0.00	0.00	20.00	0.00	2021-09-23 18:30:55.645582	-infinity
f7314fce-e10c-4af5-97e0-5eb9b6146eb8	20	sunga adulto		0.00	0.00	0.00	40.00	10.00	2021-09-23 18:19:25.276935	-infinity
f81959ed-f32a-4780-8992-ef9be8cc2619	59	saia envelope		0.00	0.00	0.00	85.50	10.00	2021-09-23 18:18:05.995605	-infinity
\.


--
-- Name: OrderItem PK_OrderItem; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."OrderItem"
    ADD CONSTRAINT "PK_OrderItem" PRIMARY KEY ("Id");


--
-- Name: Orders PK_Orders; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Orders"
    ADD CONSTRAINT "PK_Orders" PRIMARY KEY ("Id");


--
-- Name: Products PK_Products; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Products"
    ADD CONSTRAINT "PK_Products" PRIMARY KEY ("Id");


--
-- Name: IX_OrderItem_OrderId; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "IX_OrderItem_OrderId" ON public."OrderItem" USING btree ("OrderId");


--
-- Name: OrderItem FK_OrderItem_Orders_OrderId; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."OrderItem"
    ADD CONSTRAINT "FK_OrderItem_Orders_OrderId" FOREIGN KEY ("OrderId") REFERENCES public."Orders"("Id") ON DELETE CASCADE;


--
-- PostgreSQL database dump complete
--

