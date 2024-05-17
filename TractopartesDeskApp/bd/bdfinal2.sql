PGDMP  4                     |            tractopartesdb    16.2    16.2 Q    P           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            Q           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            R           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            S           1262    16639    tractopartesdb    DATABASE     �   CREATE DATABASE tractopartesdb WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Spanish_Mexico.1252';
    DROP DATABASE tractopartesdb;
                postgres    false            T           0    0    SCHEMA public    ACL     +   REVOKE USAGE ON SCHEMA public FROM PUBLIC;
                   pg_database_owner    false    5            �            1255    25275 �   crearclientedatospersonales(character varying, character varying, character varying, character varying, integer, integer, character varying) 	   PROCEDURE     �  CREATE PROCEDURE public.crearclientedatospersonales(IN nombres character varying, IN apellidomaterno character varying, IN apellidopaterno character varying, IN genero character varying, IN telefono1 integer, IN telefono2 integer, IN email character varying, OUT p_new_user integer)
    LANGUAGE plpgsql
    AS $$
begin 
insert into clientedatospersonales
(nombres,
									 apellidomaterno
									,apellidopaterno,
									genero,
									telefono1,
									telefono2,
									email)
values(nombres,apellidomaterno,apellidopaterno,
				  genero, telefono1,telefono2,email)
				  returning idclientedp into p_new_user;
				  end;
$$;
   DROP PROCEDURE public.crearclientedatospersonales(IN nombres character varying, IN apellidomaterno character varying, IN apellidopaterno character varying, IN genero character varying, IN telefono1 integer, IN telefono2 integer, IN email character varying, OUT p_new_user integer);
       public          postgres    false            �            1255    25304 c   crearproveedor(character varying, character varying, integer, character varying, character varying) 	   PROCEDURE     �  CREATE PROCEDURE public.crearproveedor(IN nombreempresa character varying, IN razonsocial character varying, IN telefono integer, IN correo character varying, IN direccion character varying, OUT p_new_producto integer)
    LANGUAGE plpgsql
    AS $$
begin 
insert into proveedores (
nombreempresa,
razonsocial,
telefono,
correo,
direccion
)
values(
NombreEmpresa,
RazonSocial,
Telefono,
Correo,
direccion
)
returning idproveedor into p_new_producto;
end;
$$;
 �   DROP PROCEDURE public.crearproveedor(IN nombreempresa character varying, IN razonsocial character varying, IN telefono integer, IN correo character varying, IN direccion character varying, OUT p_new_producto integer);
       public          postgres    false            �            1255    16975 _   crearusuariosdatosp(character varying, character varying, character varying, character varying) 	   PROCEDURE     �  CREATE PROCEDURE public.crearusuariosdatosp(IN p_nombres character varying, IN p_apellidomaterno character varying, IN p_apellidopaterno character varying, IN p_genero character varying)
    LANGUAGE plpgsql
    AS $$
begin 
insert into usuariosdatospersonales (nombres,
									 apellidoMaterno
									,apellidoPaterno,
									genero)
			values(p_nombres,p_apellidoMaterno,p_apellidoPaterno,
				  p_genero);
end;
$$;
 �   DROP PROCEDURE public.crearusuariosdatosp(IN p_nombres character varying, IN p_apellidomaterno character varying, IN p_apellidopaterno character varying, IN p_genero character varying);
       public          postgres    false            �            1255    16976    crearusuariosdatosp2() 	   PROCEDURE     �   CREATE PROCEDURE public.crearusuariosdatosp2()
    LANGUAGE plpgsql
    AS $$
begin 
insert into usuariosdatospersonales (nombres,
									 apellidoMaterno
									,apellidoPaterno,
									genero)
			values('b','z','x',
				  'y');
end;
$$;
 .   DROP PROCEDURE public.crearusuariosdatosp2();
       public          postgres    false            �            1255    25381 -   detalleventa(uuid, integer, integer, numeric) 	   PROCEDURE     �  CREATE PROCEDURE public.detalleventa(IN idventa uuid, IN p_idproducto integer, IN p_cantidad integer, IN precio_unitario numeric)
    LANGUAGE plpgsql
    AS $$
begin 
INSERT INTO public.detalle_venta(
	idventa, idproducto, cantidad, precio_unitario)
	VALUES (idventa, p_idproducto, p_cantidad, precio_unitario);
	begin
	update productos
	set cantidad=cantidad-p_cantidad
	where idproducto=p_idproducto;
	end;
end;
$$;
 �   DROP PROCEDURE public.detalleventa(IN idventa uuid, IN p_idproducto integer, IN p_cantidad integer, IN precio_unitario numeric);
       public          postgres    false            �            1255    25357 A   generarventa(uuid, timestamp without time zone, numeric, integer) 	   PROCEDURE     +  CREATE PROCEDURE public.generarventa(IN idventa uuid, IN fechaventa timestamp without time zone, IN total numeric, IN idcliente integer)
    LANGUAGE plpgsql
    AS $$
begin
INSERT INTO public.ventas(
	idventa, fechaventa, idcliente, total)
	VALUES (idventa, fechaventa,idcliente,total);

end;

$$;
 �   DROP PROCEDURE public.generarventa(IN idventa uuid, IN fechaventa timestamp without time zone, IN total numeric, IN idcliente integer);
       public          postgres    false            �            1255    25374 2   loginusuario(character varying, character varying) 	   PROCEDURE     �   CREATE PROCEDURE public.loginusuario(IN username character varying, IN contras character varying)
    LANGUAGE plpgsql
    AS $$
begin 
select * from usuarios where nombreusuario=username and password=contras;
end;

$$;
 a   DROP PROCEDURE public.loginusuario(IN username character varying, IN contras character varying);
       public          postgres    false            �            1255    25280 5   sp_addcategoria(character varying, character varying) 	   PROCEDURE       CREATE PROCEDURE public.sp_addcategoria(IN categorianombre character varying, IN descripcioncategoria character varying)
    LANGUAGE plpgsql
    AS $$
begin
insert into categorias 
(
categoria,
descripcion)
values(
CategoriaNombre,
	 DescripcionCategoria
);
end;
$$;
 x   DROP PROCEDURE public.sp_addcategoria(IN categorianombre character varying, IN descripcioncategoria character varying);
       public          postgres    false            �            1255    25364 �   sp_createproducto(character varying, character varying, character varying, character varying, numeric, numeric, integer, integer, integer) 	   PROCEDURE     9  CREATE PROCEDURE public.sp_createproducto(IN p_productonombre character varying, IN p_codigopieza character varying, IN p_descripcion character varying, IN p_imagenurl character varying, IN p_precioventa numeric, IN p_preciocompra numeric, IN p_idproveedor integer, IN p_idcategoria integer, IN p_cantidad integer, OUT p_new_producto text)
    LANGUAGE plpgsql
    AS $$
begin
	begin
INSERT INTO public.productos(
	codigopieza, descripcion, idprovedor, idcategoria, precioventa, preciocompra, cantidad, imagen,nombreproducto)
	VALUES (p_codigopieza, p_descripcion, p_idproveedor, p_idcategoria, p_precioventa, p_preciocompra, p_cantidad, p_ImagenURL,p_productonombre)
	returning idproducto into p_new_producto ;
	exception when unique_violation  then
	 p_new_producto:='Error este codigo de pieza ya existe';
	 end;
end;
$$;
 S  DROP PROCEDURE public.sp_createproducto(IN p_productonombre character varying, IN p_codigopieza character varying, IN p_descripcion character varying, IN p_imagenurl character varying, IN p_precioventa numeric, IN p_preciocompra numeric, IN p_idproveedor integer, IN p_idcategoria integer, IN p_cantidad integer, OUT p_new_producto text);
       public          postgres    false            �            1255    25278    sp_removeuser(integer) 	   PROCEDURE     �   CREATE PROCEDURE public.sp_removeuser(IN idcliente integer)
    LANGUAGE plpgsql
    AS $$
begin
delete from clientedatospersonales 
where 
idclientedp=idcliente;

end;

$$;
 ;   DROP PROCEDURE public.sp_removeuser(IN idcliente integer);
       public          postgres    false            �            1255    25379 �   sp_updateproducto(integer, character varying, character varying, integer, integer, numeric, numeric, integer, character varying, character varying) 	   PROCEDURE     �  CREATE PROCEDURE public.sp_updateproducto(IN p_idproducto integer, IN p_codigopieza character varying, IN p_descripcion character varying, IN p_idproveedor integer, IN p_idcategoria integer, IN p_precioventa numeric, IN p_preciocompra numeric, IN p_cantidad integer, IN p_imagenurl character varying, IN p_nombreproducto character varying)
    LANGUAGE plpgsql
    AS $$
begin
UPDATE public.productos
	SET  codigopieza=p_codigopieza, descripcion=p_descripcion, idprovedor=p_idproveedor,
	idcategoria=p_idcategoria, precioventa=p_precioventa, 
	preciocompra=p_preciocompra, cantidad=p_cantidad,
	imagen=p_imagenurl, nombreproducto=p_nombreproducto
	WHERE idproducto=p_idproducto;
end;

$$;
 S  DROP PROCEDURE public.sp_updateproducto(IN p_idproducto integer, IN p_codigopieza character varying, IN p_descripcion character varying, IN p_idproveedor integer, IN p_idcategoria integer, IN p_precioventa numeric, IN p_preciocompra numeric, IN p_cantidad integer, IN p_imagenurl character varying, IN p_nombreproducto character varying);
       public          postgres    false            �            1255    25376 p   sp_updateproveedor(integer, character varying, character varying, integer, character varying, character varying) 	   PROCEDURE     �  CREATE PROCEDURE public.sp_updateproveedor(IN p_idproveedor integer, IN p_nombreempresa character varying, IN p_razonsocial character varying, IN p_telefono integer, IN p_correo character varying, IN p_direccion character varying)
    LANGUAGE plpgsql
    AS $$
begin
update proveedores
set nombreempresa=p_nombreempresa,
razonsocial=p_razonsocial,
telefono=p_telefono,
correo=p_correo,
direccion=p_direccion
where idproveedor=p_idproveedor;
end;

$$;
 �   DROP PROCEDURE public.sp_updateproveedor(IN p_idproveedor integer, IN p_nombreempresa character varying, IN p_razonsocial character varying, IN p_telefono integer, IN p_correo character varying, IN p_direccion character varying);
       public          postgres    false            �            1255    17085 �   updatecliente(character varying, integer, character varying, character varying, character varying, integer, integer, character varying) 	   PROCEDURE     1  CREATE PROCEDURE public.updatecliente(IN p_nombres character varying, IN p_idcliente integer, IN p_apellidomaterno character varying, IN p_apellidopaterno character varying, IN p_genero character varying, IN p_telefono1 integer, IN p_telefono2 integer, IN p_email character varying)
    LANGUAGE plpgsql
    AS $$
begin
update clientedatospersonales 
set nombres=P_nombres,
apellidomaterno=P_apellidomaterno,
apellidopaterno=P_apellidopaterno,
genero=P_genero,
telefono1=P_telefono1,
telefono2=P_telefono2,
email=P_email
where idclientedp=P_idcliente;
end;
$$;
   DROP PROCEDURE public.updatecliente(IN p_nombres character varying, IN p_idcliente integer, IN p_apellidomaterno character varying, IN p_apellidopaterno character varying, IN p_genero character varying, IN p_telefono1 integer, IN p_telefono2 integer, IN p_email character varying);
       public          postgres    false            �            1259    25282 
   categorias    TABLE     �   CREATE TABLE public.categorias (
    idcategoria integer NOT NULL,
    categoria character varying(50),
    descripcion character varying(200)
);
    DROP TABLE public.categorias;
       public         heap    postgres    false            �            1259    25281    categorias_idcategoria_seq    SEQUENCE     �   CREATE SEQUENCE public.categorias_idcategoria_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public.categorias_idcategoria_seq;
       public          postgres    false    226            U           0    0    categorias_idcategoria_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public.categorias_idcategoria_seq OWNED BY public.categorias.idcategoria;
          public          postgres    false    225            �            1259    16981    clientedatosfiscales    TABLE     b  CREATE TABLE public.clientedatosfiscales (
    idclientedf integer NOT NULL,
    iddatos integer,
    calle character(100) NOT NULL,
    numeroexterior integer NOT NULL,
    numerointerior integer DEFAULT 0,
    colonia character(100) NOT NULL,
    codigopostal integer NOT NULL,
    estado character(100) NOT NULL,
    ciudad character(100) NOT NULL
);
 (   DROP TABLE public.clientedatosfiscales;
       public         heap    postgres    false            �            1259    16985 $   clientedatosfiscales_idclientedf_seq    SEQUENCE     �   CREATE SEQUENCE public.clientedatosfiscales_idclientedf_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ;   DROP SEQUENCE public.clientedatosfiscales_idclientedf_seq;
       public          postgres    false    215            V           0    0 $   clientedatosfiscales_idclientedf_seq    SEQUENCE OWNED BY     m   ALTER SEQUENCE public.clientedatosfiscales_idclientedf_seq OWNED BY public.clientedatosfiscales.idclientedf;
          public          postgres    false    216            �            1259    16986    clientedatospersonales    TABLE     Y  CREATE TABLE public.clientedatospersonales (
    idclientedp integer NOT NULL,
    nombres character varying(100),
    apellidomaterno character varying(30),
    apellidopaterno character varying(30),
    genero character varying(10),
    telefono1 integer NOT NULL,
    telefono2 integer DEFAULT 0,
    email character varying(100) NOT NULL
);
 *   DROP TABLE public.clientedatospersonales;
       public         heap    postgres    false            �            1259    16990 &   clientedatospersonales_idclientedp_seq    SEQUENCE     �   CREATE SEQUENCE public.clientedatospersonales_idclientedp_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 =   DROP SEQUENCE public.clientedatospersonales_idclientedp_seq;
       public          postgres    false    217            W           0    0 &   clientedatospersonales_idclientedp_seq    SEQUENCE OWNED BY     q   ALTER SEQUENCE public.clientedatospersonales_idclientedp_seq OWNED BY public.clientedatospersonales.idclientedp;
          public          postgres    false    218            �            1259    16991    detalle_productos_proveedores    TABLE     �   CREATE TABLE public.detalle_productos_proveedores (
    iddetalle integer NOT NULL,
    idproducto integer NOT NULL,
    idproveedor integer NOT NULL
);
 1   DROP TABLE public.detalle_productos_proveedores;
       public         heap    postgres    false            �            1259    16994 +   detalle_productos_proveedores_iddetalle_seq    SEQUENCE     �   CREATE SEQUENCE public.detalle_productos_proveedores_iddetalle_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 B   DROP SEQUENCE public.detalle_productos_proveedores_iddetalle_seq;
       public          postgres    false    219            X           0    0 +   detalle_productos_proveedores_iddetalle_seq    SEQUENCE OWNED BY     {   ALTER SEQUENCE public.detalle_productos_proveedores_iddetalle_seq OWNED BY public.detalle_productos_proveedores.iddetalle;
          public          postgres    false    220            �            1259    25342    detalle_venta    TABLE     �   CREATE TABLE public.detalle_venta (
    idventa uuid NOT NULL,
    idproducto integer NOT NULL,
    cantidad integer NOT NULL,
    precio_unitario numeric(10,2)
);
 !   DROP TABLE public.detalle_venta;
       public         heap    postgres    false            �            1259    16999 	   productos    TABLE     �  CREATE TABLE public.productos (
    idproducto integer NOT NULL,
    codigopieza character varying(30) NOT NULL,
    descripcion character varying(100),
    idprovedor integer,
    idcategoria integer,
    precioventa numeric(10,2) NOT NULL,
    preciocompra numeric(10,2) DEFAULT '0'::numeric,
    cantidad bigint DEFAULT '0'::bigint NOT NULL,
    imagen character varying(600),
    nombreproducto character varying(200)
);
    DROP TABLE public.productos;
       public         heap    postgres    false            �            1259    17004    productos_idproducto_seq    SEQUENCE     �   CREATE SEQUENCE public.productos_idproducto_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public.productos_idproducto_seq;
       public          postgres    false    221            Y           0    0    productos_idproducto_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE public.productos_idproducto_seq OWNED BY public.productos.idproducto;
          public          postgres    false    222            �            1259    17005    proveedores    TABLE     '  CREATE TABLE public.proveedores (
    idproveedor integer NOT NULL,
    nombreempresa character varying(50) NOT NULL,
    razonsocial character varying(50) DEFAULT 'NA'::character varying,
    telefono integer NOT NULL,
    correo character(50) NOT NULL,
    direccion character varying(300)
);
    DROP TABLE public.proveedores;
       public         heap    postgres    false            �            1259    17009    proveedores_idproveedor_seq    SEQUENCE     �   CREATE SEQUENCE public.proveedores_idproveedor_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 2   DROP SEQUENCE public.proveedores_idproveedor_seq;
       public          postgres    false    223            Z           0    0    proveedores_idproveedor_seq    SEQUENCE OWNED BY     [   ALTER SEQUENCE public.proveedores_idproveedor_seq OWNED BY public.proveedores.idproveedor;
          public          postgres    false    224            �            1259    25365    usuarios    TABLE        CREATE TABLE public.usuarios (
    idusuario integer NOT NULL,
    nombreusuario character(50) NOT NULL,
    password character(100) NOT NULL,
    nombres character(100) NOT NULL,
    apellidos character(100) NOT NULL,
    email character(100) NOT NULL
);
    DROP TABLE public.usuarios;
       public         heap    postgres    false            �            1259    25317    ventas    TABLE     �   CREATE TABLE public.ventas (
    idventa uuid NOT NULL,
    fechaventa timestamp without time zone NOT NULL,
    idcliente integer NOT NULL,
    total numeric(10,2) NOT NULL
);
    DROP TABLE public.ventas;
       public         heap    postgres    false            �           2604    25285    categorias idcategoria    DEFAULT     �   ALTER TABLE ONLY public.categorias ALTER COLUMN idcategoria SET DEFAULT nextval('public.categorias_idcategoria_seq'::regclass);
 E   ALTER TABLE public.categorias ALTER COLUMN idcategoria DROP DEFAULT;
       public          postgres    false    225    226    226            �           2604    17015     clientedatosfiscales idclientedf    DEFAULT     �   ALTER TABLE ONLY public.clientedatosfiscales ALTER COLUMN idclientedf SET DEFAULT nextval('public.clientedatosfiscales_idclientedf_seq'::regclass);
 O   ALTER TABLE public.clientedatosfiscales ALTER COLUMN idclientedf DROP DEFAULT;
       public          postgres    false    216    215            �           2604    17016 "   clientedatospersonales idclientedp    DEFAULT     �   ALTER TABLE ONLY public.clientedatospersonales ALTER COLUMN idclientedp SET DEFAULT nextval('public.clientedatospersonales_idclientedp_seq'::regclass);
 Q   ALTER TABLE public.clientedatospersonales ALTER COLUMN idclientedp DROP DEFAULT;
       public          postgres    false    218    217            �           2604    17017 '   detalle_productos_proveedores iddetalle    DEFAULT     �   ALTER TABLE ONLY public.detalle_productos_proveedores ALTER COLUMN iddetalle SET DEFAULT nextval('public.detalle_productos_proveedores_iddetalle_seq'::regclass);
 V   ALTER TABLE public.detalle_productos_proveedores ALTER COLUMN iddetalle DROP DEFAULT;
       public          postgres    false    220    219            �           2604    17019    productos idproducto    DEFAULT     |   ALTER TABLE ONLY public.productos ALTER COLUMN idproducto SET DEFAULT nextval('public.productos_idproducto_seq'::regclass);
 C   ALTER TABLE public.productos ALTER COLUMN idproducto DROP DEFAULT;
       public          postgres    false    222    221            �           2604    17020    proveedores idproveedor    DEFAULT     �   ALTER TABLE ONLY public.proveedores ALTER COLUMN idproveedor SET DEFAULT nextval('public.proveedores_idproveedor_seq'::regclass);
 F   ALTER TABLE public.proveedores ALTER COLUMN idproveedor DROP DEFAULT;
       public          postgres    false    224    223            J          0    25282 
   categorias 
   TABLE DATA           I   COPY public.categorias (idcategoria, categoria, descripcion) FROM stdin;
    public          postgres    false    226   g�       ?          0    16981    clientedatosfiscales 
   TABLE DATA           �   COPY public.clientedatosfiscales (idclientedf, iddatos, calle, numeroexterior, numerointerior, colonia, codigopostal, estado, ciudad) FROM stdin;
    public          postgres    false    215   ��       A          0    16986    clientedatospersonales 
   TABLE DATA           �   COPY public.clientedatospersonales (idclientedp, nombres, apellidomaterno, apellidopaterno, genero, telefono1, telefono2, email) FROM stdin;
    public          postgres    false    217   փ       C          0    16991    detalle_productos_proveedores 
   TABLE DATA           [   COPY public.detalle_productos_proveedores (iddetalle, idproducto, idproveedor) FROM stdin;
    public          postgres    false    219   K�       L          0    25342    detalle_venta 
   TABLE DATA           W   COPY public.detalle_venta (idventa, idproducto, cantidad, precio_unitario) FROM stdin;
    public          postgres    false    228   h�       E          0    16999 	   productos 
   TABLE DATA           �   COPY public.productos (idproducto, codigopieza, descripcion, idprovedor, idcategoria, precioventa, preciocompra, cantidad, imagen, nombreproducto) FROM stdin;
    public          postgres    false    221   ��       G          0    17005    proveedores 
   TABLE DATA           k   COPY public.proveedores (idproveedor, nombreempresa, razonsocial, telefono, correo, direccion) FROM stdin;
    public          postgres    false    223   ��       M          0    25365    usuarios 
   TABLE DATA           a   COPY public.usuarios (idusuario, nombreusuario, password, nombres, apellidos, email) FROM stdin;
    public          postgres    false    229   �       K          0    25317    ventas 
   TABLE DATA           G   COPY public.ventas (idventa, fechaventa, idcliente, total) FROM stdin;
    public          postgres    false    227   p�       [           0    0    categorias_idcategoria_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public.categorias_idcategoria_seq', 12, true);
          public          postgres    false    225            \           0    0 $   clientedatosfiscales_idclientedf_seq    SEQUENCE SET     S   SELECT pg_catalog.setval('public.clientedatosfiscales_idclientedf_seq', 1, false);
          public          postgres    false    216            ]           0    0 &   clientedatospersonales_idclientedp_seq    SEQUENCE SET     V   SELECT pg_catalog.setval('public.clientedatospersonales_idclientedp_seq', 265, true);
          public          postgres    false    218            ^           0    0 +   detalle_productos_proveedores_iddetalle_seq    SEQUENCE SET     Z   SELECT pg_catalog.setval('public.detalle_productos_proveedores_iddetalle_seq', 1, false);
          public          postgres    false    220            _           0    0    productos_idproducto_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public.productos_idproducto_seq', 84, true);
          public          postgres    false    222            `           0    0    proveedores_idproveedor_seq    SEQUENCE SET     J   SELECT pg_catalog.setval('public.proveedores_idproveedor_seq', 15, true);
          public          postgres    false    224            �           2606    25289 #   categorias categorias_categoria_key 
   CONSTRAINT     c   ALTER TABLE ONLY public.categorias
    ADD CONSTRAINT categorias_categoria_key UNIQUE (categoria);
 M   ALTER TABLE ONLY public.categorias DROP CONSTRAINT categorias_categoria_key;
       public            postgres    false    226            �           2606    25287    categorias categorias_pkey 
   CONSTRAINT     a   ALTER TABLE ONLY public.categorias
    ADD CONSTRAINT categorias_pkey PRIMARY KEY (idcategoria);
 D   ALTER TABLE ONLY public.categorias DROP CONSTRAINT categorias_pkey;
       public            postgres    false    226            �           2606    17027 5   clientedatosfiscales clientedatosfiscales_iddatos_key 
   CONSTRAINT     s   ALTER TABLE ONLY public.clientedatosfiscales
    ADD CONSTRAINT clientedatosfiscales_iddatos_key UNIQUE (iddatos);
 _   ALTER TABLE ONLY public.clientedatosfiscales DROP CONSTRAINT clientedatosfiscales_iddatos_key;
       public            postgres    false    215            �           2606    17029 .   clientedatosfiscales clientedatosfiscales_pkey 
   CONSTRAINT     u   ALTER TABLE ONLY public.clientedatosfiscales
    ADD CONSTRAINT clientedatosfiscales_pkey PRIMARY KEY (idclientedf);
 X   ALTER TABLE ONLY public.clientedatosfiscales DROP CONSTRAINT clientedatosfiscales_pkey;
       public            postgres    false    215            �           2606    17031 2   clientedatospersonales clientedatospersonales_pkey 
   CONSTRAINT     y   ALTER TABLE ONLY public.clientedatospersonales
    ADD CONSTRAINT clientedatospersonales_pkey PRIMARY KEY (idclientedp);
 \   ALTER TABLE ONLY public.clientedatospersonales DROP CONSTRAINT clientedatospersonales_pkey;
       public            postgres    false    217            �           2606    17033 @   detalle_productos_proveedores detalle_productos_proveedores_pkey 
   CONSTRAINT     �   ALTER TABLE ONLY public.detalle_productos_proveedores
    ADD CONSTRAINT detalle_productos_proveedores_pkey PRIMARY KEY (iddetalle);
 j   ALTER TABLE ONLY public.detalle_productos_proveedores DROP CONSTRAINT detalle_productos_proveedores_pkey;
       public            postgres    false    219            �           2606    25346     detalle_venta detalle_venta_pkey 
   CONSTRAINT     o   ALTER TABLE ONLY public.detalle_venta
    ADD CONSTRAINT detalle_venta_pkey PRIMARY KEY (idventa, idproducto);
 J   ALTER TABLE ONLY public.detalle_venta DROP CONSTRAINT detalle_venta_pkey;
       public            postgres    false    228    228            �           2606    17037    productos productos_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public.productos
    ADD CONSTRAINT productos_pkey PRIMARY KEY (idproducto);
 B   ALTER TABLE ONLY public.productos DROP CONSTRAINT productos_pkey;
       public            postgres    false    221            �           2606    17039    proveedores proveedores_pkey 
   CONSTRAINT     c   ALTER TABLE ONLY public.proveedores
    ADD CONSTRAINT proveedores_pkey PRIMARY KEY (idproveedor);
 F   ALTER TABLE ONLY public.proveedores DROP CONSTRAINT proveedores_pkey;
       public            postgres    false    223            �           2606    25361    productos uq_codigo 
   CONSTRAINT     U   ALTER TABLE ONLY public.productos
    ADD CONSTRAINT uq_codigo UNIQUE (codigopieza);
 =   ALTER TABLE ONLY public.productos DROP CONSTRAINT uq_codigo;
       public            postgres    false    221            �           2606    25373    usuarios usuarios_email_key 
   CONSTRAINT     W   ALTER TABLE ONLY public.usuarios
    ADD CONSTRAINT usuarios_email_key UNIQUE (email);
 E   ALTER TABLE ONLY public.usuarios DROP CONSTRAINT usuarios_email_key;
       public            postgres    false    229            �           2606    25371 #   usuarios usuarios_nombreusuario_key 
   CONSTRAINT     g   ALTER TABLE ONLY public.usuarios
    ADD CONSTRAINT usuarios_nombreusuario_key UNIQUE (nombreusuario);
 M   ALTER TABLE ONLY public.usuarios DROP CONSTRAINT usuarios_nombreusuario_key;
       public            postgres    false    229            �           2606    25369    usuarios usuarios_pkey 
   CONSTRAINT     [   ALTER TABLE ONLY public.usuarios
    ADD CONSTRAINT usuarios_pkey PRIMARY KEY (idusuario);
 @   ALTER TABLE ONLY public.usuarios DROP CONSTRAINT usuarios_pkey;
       public            postgres    false    229            �           2606    25321    ventas ventas_pkey 
   CONSTRAINT     U   ALTER TABLE ONLY public.ventas
    ADD CONSTRAINT ventas_pkey PRIMARY KEY (idventa);
 <   ALTER TABLE ONLY public.ventas DROP CONSTRAINT ventas_pkey;
       public            postgres    false    227            �           2606    25352 +   detalle_venta detalle_venta_idproducto_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.detalle_venta
    ADD CONSTRAINT detalle_venta_idproducto_fkey FOREIGN KEY (idproducto) REFERENCES public.productos(idproducto);
 U   ALTER TABLE ONLY public.detalle_venta DROP CONSTRAINT detalle_venta_idproducto_fkey;
       public          postgres    false    228    221    4758            �           2606    25347 (   detalle_venta detalle_venta_idventa_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.detalle_venta
    ADD CONSTRAINT detalle_venta_idventa_fkey FOREIGN KEY (idventa) REFERENCES public.ventas(idventa);
 R   ALTER TABLE ONLY public.detalle_venta DROP CONSTRAINT detalle_venta_idventa_fkey;
       public          postgres    false    228    4768    227            �           2606    17042 5   clientedatosfiscales fk_datosfiscales_datospersonales    FK CONSTRAINT     �   ALTER TABLE ONLY public.clientedatosfiscales
    ADD CONSTRAINT fk_datosfiscales_datospersonales FOREIGN KEY (iddatos) REFERENCES public.clientedatospersonales(idclientedp);
 _   ALTER TABLE ONLY public.clientedatosfiscales DROP CONSTRAINT fk_datosfiscales_datospersonales;
       public          postgres    false    215    4754    217            �           2606    17047 1   detalle_productos_proveedores fk_detalle_producto    FK CONSTRAINT     �   ALTER TABLE ONLY public.detalle_productos_proveedores
    ADD CONSTRAINT fk_detalle_producto FOREIGN KEY (idproducto) REFERENCES public.productos(idproducto);
 [   ALTER TABLE ONLY public.detalle_productos_proveedores DROP CONSTRAINT fk_detalle_producto;
       public          postgres    false    4758    219    221            �           2606    17052 2   detalle_productos_proveedores fk_detalle_proveedor    FK CONSTRAINT     �   ALTER TABLE ONLY public.detalle_productos_proveedores
    ADD CONSTRAINT fk_detalle_proveedor FOREIGN KEY (idproveedor) REFERENCES public.proveedores(idproveedor);
 \   ALTER TABLE ONLY public.detalle_productos_proveedores DROP CONSTRAINT fk_detalle_proveedor;
       public          postgres    false    219    4762    223            �           2606    25290    productos fk_producto_categoria    FK CONSTRAINT     �   ALTER TABLE ONLY public.productos
    ADD CONSTRAINT fk_producto_categoria FOREIGN KEY (idcategoria) REFERENCES public.categorias(idcategoria);
 I   ALTER TABLE ONLY public.productos DROP CONSTRAINT fk_producto_categoria;
       public          postgres    false    221    4766    226            �           2606    25322    ventas fk_venta_cliente    FK CONSTRAINT     �   ALTER TABLE ONLY public.ventas
    ADD CONSTRAINT fk_venta_cliente FOREIGN KEY (idcliente) REFERENCES public.clientedatospersonales(idclientedp);
 A   ALTER TABLE ONLY public.ventas DROP CONSTRAINT fk_venta_cliente;
       public          postgres    false    217    4754    227            J   B   x�3�,NL�L,N� � LK0�64�p�lߐ�4�L�,�ɇ��
�E�
ɉ���y
\1z\\\ ��      ?      x������ � �      A   e   x�323�L,N�cN �223�D�4NC#cQ��� Tb�������)0�L*J�K���L-N�OJM�G0�ʡ&�5r���%���An���b���� ��4�      C      x������ � �      L   D   x��ʱ� �����1X�]�`���4 W�&.=�N���V�4F�Z<$��KGt��kJ���T����      E   �   x���M
�0��/���O�϶]��;7�y�H���"z���E��20�cLA9OJ�.P��c��P�o�7z��L�N��́��.�i�!�4L�K}��N�h���_Mq��AzB�5�)�|'`%$�A.��!r�h�c�,X�q��~��rwk�T�u����I��g�iډB^��a[      G   v   x���1
1k�~��w}�F q������#� �`�6;�R�k��*}���Oo	2��3-�L�V��T���?$��SD�v0�>A�r�P�߄����ܬb<���s�EN      M   R   x�3�LL���S p$������D��T����O��H�ĵ89?)5%���$A|������!=713G/9?�J�p��qqq ��H      K   �   x�e̻�0 �ڞ"����Y���?B��pi�km�w��4��&�Y��>I ���/�Ku�)��`�g�CS �$}C.��b�ry���.�1݃��d�Ӥ˝@��СU��^ݝ���TB�>�q���$0�     