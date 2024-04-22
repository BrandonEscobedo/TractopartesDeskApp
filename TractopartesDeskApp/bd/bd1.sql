PGDMP                      |            tractopartesdb    16.2    16.2 7    '           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            (           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            )           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            *           1262    16398    tractopartesdb    DATABASE     �   CREATE DATABASE tractopartesdb WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Spanish_Mexico.1252';
    DROP DATABASE tractopartesdb;
                postgres    false            �            1255    16481 _   crearusuariosdatosp(character varying, character varying, character varying, character varying) 	   PROCEDURE     �  CREATE PROCEDURE public.crearusuariosdatosp(IN p_nombres character varying, IN p_apellidomaterno character varying, IN p_apellidopaterno character varying, IN p_genero character varying)
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
       public          postgres    false            �            1255    16482    crearusuariosdatosp2() 	   PROCEDURE     �   CREATE PROCEDURE public.crearusuariosdatosp2()
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
       public          postgres    false            �            1255    16483 h   crearusuariosdatospersonales(character varying, character varying, character varying, character varying) 	   PROCEDURE     �  CREATE PROCEDURE public.crearusuariosdatospersonales(IN p_nombres character varying, IN p_apellidomaterno character varying, IN p_apellidopaterno character varying, IN p_genero character varying)
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
 �   DROP PROCEDURE public.crearusuariosdatospersonales(IN p_nombres character varying, IN p_apellidomaterno character varying, IN p_apellidopaterno character varying, IN p_genero character varying);
       public          postgres    false            �            1259    16432 
   categorias    TABLE     j   CREATE TABLE public.categorias (
    idcategoria integer NOT NULL,
    categoria character varying(50)
);
    DROP TABLE public.categorias;
       public         heap    postgres    false            �            1259    16431    categorias_idcategoria_seq    SEQUENCE     �   CREATE SEQUENCE public.categorias_idcategoria_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public.categorias_idcategoria_seq;
       public          postgres    false    220            +           0    0    categorias_idcategoria_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public.categorias_idcategoria_seq OWNED BY public.categorias.idcategoria;
          public          postgres    false    219            �            1259    16449 	   productos    TABLE     '  CREATE TABLE public.productos (
    idproducto integer NOT NULL,
    codigopieza character varying(30) NOT NULL,
    descripcion character varying(100),
    idprovedor integer,
    idcategoria integer,
    precioventa numeric(5,2) NOT NULL,
    preciocompra numeric(5,2) DEFAULT '0'::numeric
);
    DROP TABLE public.productos;
       public         heap    postgres    false            �            1259    16448    productos_idproducto_seq    SEQUENCE     �   CREATE SEQUENCE public.productos_idproducto_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public.productos_idproducto_seq;
       public          postgres    false    224            ,           0    0    productos_idproducto_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE public.productos_idproducto_seq OWNED BY public.productos.idproducto;
          public          postgres    false    223            �            1259    16441    proveedores    TABLE       CREATE TABLE public.proveedores (
    idproveedor integer NOT NULL,
    nombreempresa character varying(50) NOT NULL,
    razonsocial character varying(50) DEFAULT 'NA'::character varying,
    telefono integer NOT NULL,
    correo character(50) NOT NULL
);
    DROP TABLE public.proveedores;
       public         heap    postgres    false            �            1259    16440    proveedores_idproveedor_seq    SEQUENCE     �   CREATE SEQUENCE public.proveedores_idproveedor_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 2   DROP SEQUENCE public.proveedores_idproveedor_seq;
       public          postgres    false    222            -           0    0    proveedores_idproveedor_seq    SEQUENCE OWNED BY     [   ALTER SEQUENCE public.proveedores_idproveedor_seq OWNED BY public.proveedores.idproveedor;
          public          postgres    false    221            �            1259    16467    transacciones    TABLE     �   CREATE TABLE public.transacciones (
    idtransaccion integer NOT NULL,
    idproducto integer NOT NULL,
    fechatransaccion timestamp without time zone NOT NULL
);
 !   DROP TABLE public.transacciones;
       public         heap    postgres    false            �            1259    16466    transacciones_idtransaccion_seq    SEQUENCE     �   CREATE SEQUENCE public.transacciones_idtransaccion_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 6   DROP SEQUENCE public.transacciones_idtransaccion_seq;
       public          postgres    false    226            .           0    0    transacciones_idtransaccion_seq    SEQUENCE OWNED BY     c   ALTER SEQUENCE public.transacciones_idtransaccion_seq OWNED BY public.transacciones.idtransaccion;
          public          postgres    false    225            �            1259    16414    usuariodatosfiscales    TABLE     �  CREATE TABLE public.usuariodatosfiscales (
    iddatos integer NOT NULL,
    idusuario integer,
    calle character(100) NOT NULL,
    numeroexterior integer NOT NULL,
    numerointerior integer DEFAULT 0,
    colonia character(100) NOT NULL,
    codigopostal integer NOT NULL,
    estado character(100) NOT NULL,
    ciudad character(100) NOT NULL,
    telefono1 integer NOT NULL,
    telefono2 integer DEFAULT 0,
    email character varying(100) NOT NULL
);
 (   DROP TABLE public.usuariodatosfiscales;
       public         heap    postgres    false            �            1259    16413     usuariodatosfiscales_iddatos_seq    SEQUENCE     �   CREATE SEQUENCE public.usuariodatosfiscales_iddatos_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 7   DROP SEQUENCE public.usuariodatosfiscales_iddatos_seq;
       public          postgres    false    218            /           0    0     usuariodatosfiscales_iddatos_seq    SEQUENCE OWNED BY     e   ALTER SEQUENCE public.usuariodatosfiscales_iddatos_seq OWNED BY public.usuariodatosfiscales.iddatos;
          public          postgres    false    217            �            1259    16407    usuariosdatospersonales    TABLE     �   CREATE TABLE public.usuariosdatospersonales (
    idusuario integer NOT NULL,
    nombres character varying(100),
    apellidomaterno character varying(30),
    apellidopaterno character varying(30),
    genero character varying(10)
);
 +   DROP TABLE public.usuariosdatospersonales;
       public         heap    postgres    false            �            1259    16406 %   usuariosdatospersonales_idusuario_seq    SEQUENCE     �   CREATE SEQUENCE public.usuariosdatospersonales_idusuario_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 <   DROP SEQUENCE public.usuariosdatospersonales_idusuario_seq;
       public          postgres    false    216            0           0    0 %   usuariosdatospersonales_idusuario_seq    SEQUENCE OWNED BY     o   ALTER SEQUENCE public.usuariosdatospersonales_idusuario_seq OWNED BY public.usuariosdatospersonales.idusuario;
          public          postgres    false    215            p           2604    16435    categorias idcategoria    DEFAULT     �   ALTER TABLE ONLY public.categorias ALTER COLUMN idcategoria SET DEFAULT nextval('public.categorias_idcategoria_seq'::regclass);
 E   ALTER TABLE public.categorias ALTER COLUMN idcategoria DROP DEFAULT;
       public          postgres    false    219    220    220            s           2604    16452    productos idproducto    DEFAULT     |   ALTER TABLE ONLY public.productos ALTER COLUMN idproducto SET DEFAULT nextval('public.productos_idproducto_seq'::regclass);
 C   ALTER TABLE public.productos ALTER COLUMN idproducto DROP DEFAULT;
       public          postgres    false    224    223    224            q           2604    16444    proveedores idproveedor    DEFAULT     �   ALTER TABLE ONLY public.proveedores ALTER COLUMN idproveedor SET DEFAULT nextval('public.proveedores_idproveedor_seq'::regclass);
 F   ALTER TABLE public.proveedores ALTER COLUMN idproveedor DROP DEFAULT;
       public          postgres    false    221    222    222            u           2604    16470    transacciones idtransaccion    DEFAULT     �   ALTER TABLE ONLY public.transacciones ALTER COLUMN idtransaccion SET DEFAULT nextval('public.transacciones_idtransaccion_seq'::regclass);
 J   ALTER TABLE public.transacciones ALTER COLUMN idtransaccion DROP DEFAULT;
       public          postgres    false    226    225    226            m           2604    16417    usuariodatosfiscales iddatos    DEFAULT     �   ALTER TABLE ONLY public.usuariodatosfiscales ALTER COLUMN iddatos SET DEFAULT nextval('public.usuariodatosfiscales_iddatos_seq'::regclass);
 K   ALTER TABLE public.usuariodatosfiscales ALTER COLUMN iddatos DROP DEFAULT;
       public          postgres    false    217    218    218            l           2604    16410 !   usuariosdatospersonales idusuario    DEFAULT     �   ALTER TABLE ONLY public.usuariosdatospersonales ALTER COLUMN idusuario SET DEFAULT nextval('public.usuariosdatospersonales_idusuario_seq'::regclass);
 P   ALTER TABLE public.usuariosdatospersonales ALTER COLUMN idusuario DROP DEFAULT;
       public          postgres    false    215    216    216                      0    16432 
   categorias 
   TABLE DATA           <   COPY public.categorias (idcategoria, categoria) FROM stdin;
    public          postgres    false    220   {J       "          0    16449 	   productos 
   TABLE DATA           }   COPY public.productos (idproducto, codigopieza, descripcion, idprovedor, idcategoria, precioventa, preciocompra) FROM stdin;
    public          postgres    false    224   �J                  0    16441    proveedores 
   TABLE DATA           `   COPY public.proveedores (idproveedor, nombreempresa, razonsocial, telefono, correo) FROM stdin;
    public          postgres    false    222   �J       $          0    16467    transacciones 
   TABLE DATA           T   COPY public.transacciones (idtransaccion, idproducto, fechatransaccion) FROM stdin;
    public          postgres    false    226   �J                 0    16414    usuariodatosfiscales 
   TABLE DATA           �   COPY public.usuariodatosfiscales (iddatos, idusuario, calle, numeroexterior, numerointerior, colonia, codigopostal, estado, ciudad, telefono1, telefono2, email) FROM stdin;
    public          postgres    false    218   �J                 0    16407    usuariosdatospersonales 
   TABLE DATA           o   COPY public.usuariosdatospersonales (idusuario, nombres, apellidomaterno, apellidopaterno, genero) FROM stdin;
    public          postgres    false    216   K       1           0    0    categorias_idcategoria_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public.categorias_idcategoria_seq', 1, false);
          public          postgres    false    219            2           0    0    productos_idproducto_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public.productos_idproducto_seq', 1, false);
          public          postgres    false    223            3           0    0    proveedores_idproveedor_seq    SEQUENCE SET     J   SELECT pg_catalog.setval('public.proveedores_idproveedor_seq', 1, false);
          public          postgres    false    221            4           0    0    transacciones_idtransaccion_seq    SEQUENCE SET     N   SELECT pg_catalog.setval('public.transacciones_idtransaccion_seq', 1, false);
          public          postgres    false    225            5           0    0     usuariodatosfiscales_iddatos_seq    SEQUENCE SET     O   SELECT pg_catalog.setval('public.usuariodatosfiscales_iddatos_seq', 1, false);
          public          postgres    false    217            6           0    0 %   usuariosdatospersonales_idusuario_seq    SEQUENCE SET     T   SELECT pg_catalog.setval('public.usuariosdatospersonales_idusuario_seq', 17, true);
          public          postgres    false    215            }           2606    16439 #   categorias categorias_categoria_key 
   CONSTRAINT     c   ALTER TABLE ONLY public.categorias
    ADD CONSTRAINT categorias_categoria_key UNIQUE (categoria);
 M   ALTER TABLE ONLY public.categorias DROP CONSTRAINT categorias_categoria_key;
       public            postgres    false    220                       2606    16437    categorias categorias_pkey 
   CONSTRAINT     a   ALTER TABLE ONLY public.categorias
    ADD CONSTRAINT categorias_pkey PRIMARY KEY (idcategoria);
 D   ALTER TABLE ONLY public.categorias DROP CONSTRAINT categorias_pkey;
       public            postgres    false    220            �           2606    16455    productos productos_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public.productos
    ADD CONSTRAINT productos_pkey PRIMARY KEY (idproducto);
 B   ALTER TABLE ONLY public.productos DROP CONSTRAINT productos_pkey;
       public            postgres    false    224            �           2606    16447    proveedores proveedores_pkey 
   CONSTRAINT     c   ALTER TABLE ONLY public.proveedores
    ADD CONSTRAINT proveedores_pkey PRIMARY KEY (idproveedor);
 F   ALTER TABLE ONLY public.proveedores DROP CONSTRAINT proveedores_pkey;
       public            postgres    false    222            �           2606    16472     transacciones transacciones_pkey 
   CONSTRAINT     i   ALTER TABLE ONLY public.transacciones
    ADD CONSTRAINT transacciones_pkey PRIMARY KEY (idtransaccion);
 J   ALTER TABLE ONLY public.transacciones DROP CONSTRAINT transacciones_pkey;
       public            postgres    false    226            y           2606    16425 7   usuariodatosfiscales usuariodatosfiscales_idusuario_key 
   CONSTRAINT     w   ALTER TABLE ONLY public.usuariodatosfiscales
    ADD CONSTRAINT usuariodatosfiscales_idusuario_key UNIQUE (idusuario);
 a   ALTER TABLE ONLY public.usuariodatosfiscales DROP CONSTRAINT usuariodatosfiscales_idusuario_key;
       public            postgres    false    218            {           2606    16423 .   usuariodatosfiscales usuariodatosfiscales_pkey 
   CONSTRAINT     q   ALTER TABLE ONLY public.usuariodatosfiscales
    ADD CONSTRAINT usuariodatosfiscales_pkey PRIMARY KEY (iddatos);
 X   ALTER TABLE ONLY public.usuariodatosfiscales DROP CONSTRAINT usuariodatosfiscales_pkey;
       public            postgres    false    218            w           2606    16412 4   usuariosdatospersonales usuariosdatospersonales_pkey 
   CONSTRAINT     y   ALTER TABLE ONLY public.usuariosdatospersonales
    ADD CONSTRAINT usuariosdatospersonales_pkey PRIMARY KEY (idusuario);
 ^   ALTER TABLE ONLY public.usuariosdatospersonales DROP CONSTRAINT usuariosdatospersonales_pkey;
       public            postgres    false    216            �           2606    16456    productos fk_producto_categoria    FK CONSTRAINT     �   ALTER TABLE ONLY public.productos
    ADD CONSTRAINT fk_producto_categoria FOREIGN KEY (idcategoria) REFERENCES public.categorias(idcategoria);
 I   ALTER TABLE ONLY public.productos DROP CONSTRAINT fk_producto_categoria;
       public          postgres    false    224    4735    220            �           2606    16461    productos fk_producto_proveedor    FK CONSTRAINT     �   ALTER TABLE ONLY public.productos
    ADD CONSTRAINT fk_producto_proveedor FOREIGN KEY (idprovedor) REFERENCES public.proveedores(idproveedor);
 I   ALTER TABLE ONLY public.productos DROP CONSTRAINT fk_producto_proveedor;
       public          postgres    false    4737    224    222            �           2606    16473 &   transacciones fk_transaccion_productos    FK CONSTRAINT     �   ALTER TABLE ONLY public.transacciones
    ADD CONSTRAINT fk_transaccion_productos FOREIGN KEY (idproducto) REFERENCES public.productos(idproducto);
 P   ALTER TABLE ONLY public.transacciones DROP CONSTRAINT fk_transaccion_productos;
       public          postgres    false    224    4739    226            �           2606    16426 -   usuariodatosfiscales fk_usuario_datosfiscales    FK CONSTRAINT     �   ALTER TABLE ONLY public.usuariodatosfiscales
    ADD CONSTRAINT fk_usuario_datosfiscales FOREIGN KEY (idusuario) REFERENCES public.usuariosdatospersonales(idusuario);
 W   ALTER TABLE ONLY public.usuariodatosfiscales DROP CONSTRAINT fk_usuario_datosfiscales;
       public          postgres    false    216    4727    218                  x������ � �      "      x������ � �             x������ � �      $      x������ � �            x������ � �         z   x�m�K
�@D�U�	���
o��h��0�v���q&�0 të�(J0Xx*�m��Ԗ=�3Ya�Ý�S��:u;}�ƇW����"��H��,UY��MqO�S��&g�%�R�X����|\H� =?�     