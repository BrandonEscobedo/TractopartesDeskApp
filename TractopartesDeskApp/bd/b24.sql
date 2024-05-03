PGDMP  *    5                |            tractopartesdb    16.2    16.2 L    @           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            A           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            B           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            C           1262    16639    tractopartesdb    DATABASE     �   CREATE DATABASE tractopartesdb WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Spanish_Mexico.1252';
    DROP DATABASE tractopartesdb;
                postgres    false                        2615    16972    public    SCHEMA        CREATE SCHEMA public;
    DROP SCHEMA public;
                pg_database_owner    false            D           0    0    SCHEMA public    COMMENT     6   COMMENT ON SCHEMA public IS 'standard public schema';
                   pg_database_owner    false    5            E           0    0    SCHEMA public    ACL     +   REVOKE USAGE ON SCHEMA public FROM PUBLIC;
                   pg_database_owner    false    5            �            1255    16973 �   crearclientedatospersonales(character varying, character varying, character varying, character varying, integer, integer, character varying) 	   PROCEDURE     =  CREATE PROCEDURE public.crearclientedatospersonales(IN nombres character varying, IN apellidomaterno character varying, IN apellidopaterno character varying, IN genero character varying, IN telefono1 integer, IN telefono2 integer, IN email character varying)
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
				  genero, telefono1,telefono2,email);
				  end;
$$;
   DROP PROCEDURE public.crearclientedatospersonales(IN nombres character varying, IN apellidomaterno character varying, IN apellidopaterno character varying, IN genero character varying, IN telefono1 integer, IN telefono2 integer, IN email character varying);
       public          postgres    false    5            �            1255    16974 c   crearproveedor(character varying, character varying, integer, character varying, character varying) 	   PROCEDURE     �  CREATE PROCEDURE public.crearproveedor(IN nombreempresa character varying, IN razonsocial character varying, IN telefono integer, IN correo character varying, IN direccion character varying)
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
);
end;
$$;
 �   DROP PROCEDURE public.crearproveedor(IN nombreempresa character varying, IN razonsocial character varying, IN telefono integer, IN correo character varying, IN direccion character varying);
       public          postgres    false    5            �            1255    16975 _   crearusuariosdatosp(character varying, character varying, character varying, character varying) 	   PROCEDURE     �  CREATE PROCEDURE public.crearusuariosdatosp(IN p_nombres character varying, IN p_apellidomaterno character varying, IN p_apellidopaterno character varying, IN p_genero character varying)
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
       public          postgres    false    5            �            1255    16976    crearusuariosdatosp2() 	   PROCEDURE     �   CREATE PROCEDURE public.crearusuariosdatosp2()
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
       public          postgres    false    5            �            1259    16977 
   categorias    TABLE     j   CREATE TABLE public.categorias (
    idcategoria integer NOT NULL,
    categoria character varying(50)
);
    DROP TABLE public.categorias;
       public         heap    postgres    false    5            �            1259    16980    categorias_idcategoria_seq    SEQUENCE     �   CREATE SEQUENCE public.categorias_idcategoria_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public.categorias_idcategoria_seq;
       public          postgres    false    5    215            F           0    0    categorias_idcategoria_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public.categorias_idcategoria_seq OWNED BY public.categorias.idcategoria;
          public          postgres    false    216            �            1259    16981    clientedatosfiscales    TABLE     b  CREATE TABLE public.clientedatosfiscales (
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
       public         heap    postgres    false    5            �            1259    16985 $   clientedatosfiscales_idclientedf_seq    SEQUENCE     �   CREATE SEQUENCE public.clientedatosfiscales_idclientedf_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ;   DROP SEQUENCE public.clientedatosfiscales_idclientedf_seq;
       public          postgres    false    217    5            G           0    0 $   clientedatosfiscales_idclientedf_seq    SEQUENCE OWNED BY     m   ALTER SEQUENCE public.clientedatosfiscales_idclientedf_seq OWNED BY public.clientedatosfiscales.idclientedf;
          public          postgres    false    218            �            1259    16986    clientedatospersonales    TABLE     Y  CREATE TABLE public.clientedatospersonales (
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
       public         heap    postgres    false    5            �            1259    16990 &   clientedatospersonales_idclientedp_seq    SEQUENCE     �   CREATE SEQUENCE public.clientedatospersonales_idclientedp_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 =   DROP SEQUENCE public.clientedatospersonales_idclientedp_seq;
       public          postgres    false    219    5            H           0    0 &   clientedatospersonales_idclientedp_seq    SEQUENCE OWNED BY     q   ALTER SEQUENCE public.clientedatospersonales_idclientedp_seq OWNED BY public.clientedatospersonales.idclientedp;
          public          postgres    false    220            �            1259    16991    detalle_productos_proveedores    TABLE     �   CREATE TABLE public.detalle_productos_proveedores (
    iddetalle integer NOT NULL,
    idproducto integer NOT NULL,
    idproveedor integer NOT NULL
);
 1   DROP TABLE public.detalle_productos_proveedores;
       public         heap    postgres    false    5            �            1259    16994 +   detalle_productos_proveedores_iddetalle_seq    SEQUENCE     �   CREATE SEQUENCE public.detalle_productos_proveedores_iddetalle_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 B   DROP SEQUENCE public.detalle_productos_proveedores_iddetalle_seq;
       public          postgres    false    221    5            I           0    0 +   detalle_productos_proveedores_iddetalle_seq    SEQUENCE OWNED BY     {   ALTER SEQUENCE public.detalle_productos_proveedores_iddetalle_seq OWNED BY public.detalle_productos_proveedores.iddetalle;
          public          postgres    false    222            �            1259    16995    detalleventa    TABLE     �   CREATE TABLE public.detalleventa (
    iddetalleventa integer NOT NULL,
    idtransaccion integer NOT NULL,
    idproducto integer NOT NULL,
    cantidad integer NOT NULL,
    precioventa numeric(10,2)
);
     DROP TABLE public.detalleventa;
       public         heap    postgres    false    5            �            1259    16998    detalleventa_iddetalleventa_seq    SEQUENCE     �   CREATE SEQUENCE public.detalleventa_iddetalleventa_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 6   DROP SEQUENCE public.detalleventa_iddetalleventa_seq;
       public          postgres    false    223    5            J           0    0    detalleventa_iddetalleventa_seq    SEQUENCE OWNED BY     c   ALTER SEQUENCE public.detalleventa_iddetalleventa_seq OWNED BY public.detalleventa.iddetalleventa;
          public          postgres    false    224            �            1259    16999 	   productos    TABLE     Y  CREATE TABLE public.productos (
    idproducto integer NOT NULL,
    codigopieza character varying(30) NOT NULL,
    descripcion character varying(100),
    idprovedor integer,
    idcategoria integer,
    precioventa numeric(5,2) NOT NULL,
    preciocompra numeric(5,2) DEFAULT '0'::numeric,
    cantidad bigint DEFAULT '0'::bigint NOT NULL
);
    DROP TABLE public.productos;
       public         heap    postgres    false    5            �            1259    17004    productos_idproducto_seq    SEQUENCE     �   CREATE SEQUENCE public.productos_idproducto_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public.productos_idproducto_seq;
       public          postgres    false    225    5            K           0    0    productos_idproducto_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE public.productos_idproducto_seq OWNED BY public.productos.idproducto;
          public          postgres    false    226            �            1259    17005    proveedores    TABLE     '  CREATE TABLE public.proveedores (
    idproveedor integer NOT NULL,
    nombreempresa character varying(50) NOT NULL,
    razonsocial character varying(50) DEFAULT 'NA'::character varying,
    telefono integer NOT NULL,
    correo character(50) NOT NULL,
    direccion character varying(300)
);
    DROP TABLE public.proveedores;
       public         heap    postgres    false    5            �            1259    17009    proveedores_idproveedor_seq    SEQUENCE     �   CREATE SEQUENCE public.proveedores_idproveedor_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 2   DROP SEQUENCE public.proveedores_idproveedor_seq;
       public          postgres    false    227    5            L           0    0    proveedores_idproveedor_seq    SEQUENCE OWNED BY     [   ALTER SEQUENCE public.proveedores_idproveedor_seq OWNED BY public.proveedores.idproveedor;
          public          postgres    false    228            �            1259    17010    transacciones    TABLE     �   CREATE TABLE public.transacciones (
    idtransaccion integer NOT NULL,
    idcliente integer NOT NULL,
    fechatransaccion timestamp without time zone NOT NULL,
    total numeric(10,2)
);
 !   DROP TABLE public.transacciones;
       public         heap    postgres    false    5            �            1259    17013    transacciones_idtransaccion_seq    SEQUENCE     �   CREATE SEQUENCE public.transacciones_idtransaccion_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 6   DROP SEQUENCE public.transacciones_idtransaccion_seq;
       public          postgres    false    229    5            M           0    0    transacciones_idtransaccion_seq    SEQUENCE OWNED BY     c   ALTER SEQUENCE public.transacciones_idtransaccion_seq OWNED BY public.transacciones.idtransaccion;
          public          postgres    false    230            w           2604    17014    categorias idcategoria    DEFAULT     �   ALTER TABLE ONLY public.categorias ALTER COLUMN idcategoria SET DEFAULT nextval('public.categorias_idcategoria_seq'::regclass);
 E   ALTER TABLE public.categorias ALTER COLUMN idcategoria DROP DEFAULT;
       public          postgres    false    216    215            x           2604    17015     clientedatosfiscales idclientedf    DEFAULT     �   ALTER TABLE ONLY public.clientedatosfiscales ALTER COLUMN idclientedf SET DEFAULT nextval('public.clientedatosfiscales_idclientedf_seq'::regclass);
 O   ALTER TABLE public.clientedatosfiscales ALTER COLUMN idclientedf DROP DEFAULT;
       public          postgres    false    218    217            z           2604    17016 "   clientedatospersonales idclientedp    DEFAULT     �   ALTER TABLE ONLY public.clientedatospersonales ALTER COLUMN idclientedp SET DEFAULT nextval('public.clientedatospersonales_idclientedp_seq'::regclass);
 Q   ALTER TABLE public.clientedatospersonales ALTER COLUMN idclientedp DROP DEFAULT;
       public          postgres    false    220    219            |           2604    17017 '   detalle_productos_proveedores iddetalle    DEFAULT     �   ALTER TABLE ONLY public.detalle_productos_proveedores ALTER COLUMN iddetalle SET DEFAULT nextval('public.detalle_productos_proveedores_iddetalle_seq'::regclass);
 V   ALTER TABLE public.detalle_productos_proveedores ALTER COLUMN iddetalle DROP DEFAULT;
       public          postgres    false    222    221            }           2604    17018    detalleventa iddetalleventa    DEFAULT     �   ALTER TABLE ONLY public.detalleventa ALTER COLUMN iddetalleventa SET DEFAULT nextval('public.detalleventa_iddetalleventa_seq'::regclass);
 J   ALTER TABLE public.detalleventa ALTER COLUMN iddetalleventa DROP DEFAULT;
       public          postgres    false    224    223            ~           2604    17019    productos idproducto    DEFAULT     |   ALTER TABLE ONLY public.productos ALTER COLUMN idproducto SET DEFAULT nextval('public.productos_idproducto_seq'::regclass);
 C   ALTER TABLE public.productos ALTER COLUMN idproducto DROP DEFAULT;
       public          postgres    false    226    225            �           2604    17020    proveedores idproveedor    DEFAULT     �   ALTER TABLE ONLY public.proveedores ALTER COLUMN idproveedor SET DEFAULT nextval('public.proveedores_idproveedor_seq'::regclass);
 F   ALTER TABLE public.proveedores ALTER COLUMN idproveedor DROP DEFAULT;
       public          postgres    false    228    227            �           2604    17021    transacciones idtransaccion    DEFAULT     �   ALTER TABLE ONLY public.transacciones ALTER COLUMN idtransaccion SET DEFAULT nextval('public.transacciones_idtransaccion_seq'::regclass);
 J   ALTER TABLE public.transacciones ALTER COLUMN idtransaccion DROP DEFAULT;
       public          postgres    false    230    229            .          0    16977 
   categorias 
   TABLE DATA           <   COPY public.categorias (idcategoria, categoria) FROM stdin;
    public          postgres    false    215   fi       0          0    16981    clientedatosfiscales 
   TABLE DATA           �   COPY public.clientedatosfiscales (idclientedf, iddatos, calle, numeroexterior, numerointerior, colonia, codigopostal, estado, ciudad) FROM stdin;
    public          postgres    false    217   �i       2          0    16986    clientedatospersonales 
   TABLE DATA           �   COPY public.clientedatospersonales (idclientedp, nombres, apellidomaterno, apellidopaterno, genero, telefono1, telefono2, email) FROM stdin;
    public          postgres    false    219   �i       4          0    16991    detalle_productos_proveedores 
   TABLE DATA           [   COPY public.detalle_productos_proveedores (iddetalle, idproducto, idproveedor) FROM stdin;
    public          postgres    false    221   j       6          0    16995    detalleventa 
   TABLE DATA           h   COPY public.detalleventa (iddetalleventa, idtransaccion, idproducto, cantidad, precioventa) FROM stdin;
    public          postgres    false    223   %j       8          0    16999 	   productos 
   TABLE DATA           �   COPY public.productos (idproducto, codigopieza, descripcion, idprovedor, idcategoria, precioventa, preciocompra, cantidad) FROM stdin;
    public          postgres    false    225   Bj       :          0    17005    proveedores 
   TABLE DATA           k   COPY public.proveedores (idproveedor, nombreempresa, razonsocial, telefono, correo, direccion) FROM stdin;
    public          postgres    false    227   _j       <          0    17010    transacciones 
   TABLE DATA           Z   COPY public.transacciones (idtransaccion, idcliente, fechatransaccion, total) FROM stdin;
    public          postgres    false    229   �j       N           0    0    categorias_idcategoria_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public.categorias_idcategoria_seq', 1, false);
          public          postgres    false    216            O           0    0 $   clientedatosfiscales_idclientedf_seq    SEQUENCE SET     S   SELECT pg_catalog.setval('public.clientedatosfiscales_idclientedf_seq', 1, false);
          public          postgres    false    218            P           0    0 &   clientedatospersonales_idclientedp_seq    SEQUENCE SET     U   SELECT pg_catalog.setval('public.clientedatospersonales_idclientedp_seq', 64, true);
          public          postgres    false    220            Q           0    0 +   detalle_productos_proveedores_iddetalle_seq    SEQUENCE SET     Z   SELECT pg_catalog.setval('public.detalle_productos_proveedores_iddetalle_seq', 1, false);
          public          postgres    false    222            R           0    0    detalleventa_iddetalleventa_seq    SEQUENCE SET     N   SELECT pg_catalog.setval('public.detalleventa_iddetalleventa_seq', 1, false);
          public          postgres    false    224            S           0    0    productos_idproducto_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public.productos_idproducto_seq', 1, false);
          public          postgres    false    226            T           0    0    proveedores_idproveedor_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public.proveedores_idproveedor_seq', 2, true);
          public          postgres    false    228            U           0    0    transacciones_idtransaccion_seq    SEQUENCE SET     N   SELECT pg_catalog.setval('public.transacciones_idtransaccion_seq', 1, false);
          public          postgres    false    230            �           2606    17023 #   categorias categorias_categoria_key 
   CONSTRAINT     c   ALTER TABLE ONLY public.categorias
    ADD CONSTRAINT categorias_categoria_key UNIQUE (categoria);
 M   ALTER TABLE ONLY public.categorias DROP CONSTRAINT categorias_categoria_key;
       public            postgres    false    215            �           2606    17025    categorias categorias_pkey 
   CONSTRAINT     a   ALTER TABLE ONLY public.categorias
    ADD CONSTRAINT categorias_pkey PRIMARY KEY (idcategoria);
 D   ALTER TABLE ONLY public.categorias DROP CONSTRAINT categorias_pkey;
       public            postgres    false    215            �           2606    17027 5   clientedatosfiscales clientedatosfiscales_iddatos_key 
   CONSTRAINT     s   ALTER TABLE ONLY public.clientedatosfiscales
    ADD CONSTRAINT clientedatosfiscales_iddatos_key UNIQUE (iddatos);
 _   ALTER TABLE ONLY public.clientedatosfiscales DROP CONSTRAINT clientedatosfiscales_iddatos_key;
       public            postgres    false    217            �           2606    17029 .   clientedatosfiscales clientedatosfiscales_pkey 
   CONSTRAINT     u   ALTER TABLE ONLY public.clientedatosfiscales
    ADD CONSTRAINT clientedatosfiscales_pkey PRIMARY KEY (idclientedf);
 X   ALTER TABLE ONLY public.clientedatosfiscales DROP CONSTRAINT clientedatosfiscales_pkey;
       public            postgres    false    217            �           2606    17031 2   clientedatospersonales clientedatospersonales_pkey 
   CONSTRAINT     y   ALTER TABLE ONLY public.clientedatospersonales
    ADD CONSTRAINT clientedatospersonales_pkey PRIMARY KEY (idclientedp);
 \   ALTER TABLE ONLY public.clientedatospersonales DROP CONSTRAINT clientedatospersonales_pkey;
       public            postgres    false    219            �           2606    17033 @   detalle_productos_proveedores detalle_productos_proveedores_pkey 
   CONSTRAINT     �   ALTER TABLE ONLY public.detalle_productos_proveedores
    ADD CONSTRAINT detalle_productos_proveedores_pkey PRIMARY KEY (iddetalle);
 j   ALTER TABLE ONLY public.detalle_productos_proveedores DROP CONSTRAINT detalle_productos_proveedores_pkey;
       public            postgres    false    221            �           2606    17035    detalleventa detalleventa_pkey 
   CONSTRAINT     h   ALTER TABLE ONLY public.detalleventa
    ADD CONSTRAINT detalleventa_pkey PRIMARY KEY (iddetalleventa);
 H   ALTER TABLE ONLY public.detalleventa DROP CONSTRAINT detalleventa_pkey;
       public            postgres    false    223            �           2606    17037    productos productos_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public.productos
    ADD CONSTRAINT productos_pkey PRIMARY KEY (idproducto);
 B   ALTER TABLE ONLY public.productos DROP CONSTRAINT productos_pkey;
       public            postgres    false    225            �           2606    17039    proveedores proveedores_pkey 
   CONSTRAINT     c   ALTER TABLE ONLY public.proveedores
    ADD CONSTRAINT proveedores_pkey PRIMARY KEY (idproveedor);
 F   ALTER TABLE ONLY public.proveedores DROP CONSTRAINT proveedores_pkey;
       public            postgres    false    227            �           2606    17041     transacciones transacciones_pkey 
   CONSTRAINT     i   ALTER TABLE ONLY public.transacciones
    ADD CONSTRAINT transacciones_pkey PRIMARY KEY (idtransaccion);
 J   ALTER TABLE ONLY public.transacciones DROP CONSTRAINT transacciones_pkey;
       public            postgres    false    229            �           2606    17042 5   clientedatosfiscales fk_datosfiscales_datospersonales    FK CONSTRAINT     �   ALTER TABLE ONLY public.clientedatosfiscales
    ADD CONSTRAINT fk_datosfiscales_datospersonales FOREIGN KEY (iddatos) REFERENCES public.clientedatospersonales(idclientedp);
 _   ALTER TABLE ONLY public.clientedatosfiscales DROP CONSTRAINT fk_datosfiscales_datospersonales;
       public          postgres    false    217    219    4749            �           2606    17047 1   detalle_productos_proveedores fk_detalle_producto    FK CONSTRAINT     �   ALTER TABLE ONLY public.detalle_productos_proveedores
    ADD CONSTRAINT fk_detalle_producto FOREIGN KEY (idproducto) REFERENCES public.productos(idproducto);
 [   ALTER TABLE ONLY public.detalle_productos_proveedores DROP CONSTRAINT fk_detalle_producto;
       public          postgres    false    225    4755    221            �           2606    17052 2   detalle_productos_proveedores fk_detalle_proveedor    FK CONSTRAINT     �   ALTER TABLE ONLY public.detalle_productos_proveedores
    ADD CONSTRAINT fk_detalle_proveedor FOREIGN KEY (idproveedor) REFERENCES public.proveedores(idproveedor);
 \   ALTER TABLE ONLY public.detalle_productos_proveedores DROP CONSTRAINT fk_detalle_proveedor;
       public          postgres    false    227    4757    221            �           2606    17057 %   detalleventa fk_detalleventa_producto    FK CONSTRAINT     �   ALTER TABLE ONLY public.detalleventa
    ADD CONSTRAINT fk_detalleventa_producto FOREIGN KEY (idproducto) REFERENCES public.productos(idproducto);
 O   ALTER TABLE ONLY public.detalleventa DROP CONSTRAINT fk_detalleventa_producto;
       public          postgres    false    223    225    4755            �           2606    17062 (   detalleventa fk_detalleventa_transaccion    FK CONSTRAINT     �   ALTER TABLE ONLY public.detalleventa
    ADD CONSTRAINT fk_detalleventa_transaccion FOREIGN KEY (idtransaccion) REFERENCES public.transacciones(idtransaccion);
 R   ALTER TABLE ONLY public.detalleventa DROP CONSTRAINT fk_detalleventa_transaccion;
       public          postgres    false    223    229    4759            �           2606    17067    productos fk_producto_categoria    FK CONSTRAINT     �   ALTER TABLE ONLY public.productos
    ADD CONSTRAINT fk_producto_categoria FOREIGN KEY (idcategoria) REFERENCES public.categorias(idcategoria);
 I   ALTER TABLE ONLY public.productos DROP CONSTRAINT fk_producto_categoria;
       public          postgres    false    225    215    4743            �           2606    17072 &   transacciones fk_transaccion_idcliente    FK CONSTRAINT     �   ALTER TABLE ONLY public.transacciones
    ADD CONSTRAINT fk_transaccion_idcliente FOREIGN KEY (idcliente) REFERENCES public.clientedatospersonales(idclientedp);
 P   ALTER TABLE ONLY public.transacciones DROP CONSTRAINT fk_transaccion_idcliente;
       public          postgres    false    4749    219    229            .      x������ � �      0      x������ � �      2   X   x�3��L*J�K�,�O)*��L-N���4426���)@�ejI�23 ���a45\f���҉��F���Q��ХM��#T�,����� �\;      4      x������ � �      6      x������ � �      8      x������ � �      :   2   x�3�L*J�K�L-N�442�L,NQ ��p�H���r������� �j      <      x������ � �     