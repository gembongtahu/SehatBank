PGDMP         ,            
    {         	   SehatBank    15.3    15.2 T    T           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            U           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            V           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            W           1262    17802 	   SehatBank    DATABASE     �   CREATE DATABASE "SehatBank" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_Indonesia.1252';
    DROP DATABASE "SehatBank";
                postgres    false            �            1255    17941    activitiestable_select()    FUNCTION     #  CREATE FUNCTION public.activitiestable_select() RETURNS TABLE(_activities_id character varying, _activities_name character varying, _calories_burned smallint)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	select activities_id, activities_name, calories_burned from activities;
end
$$;
 /   DROP FUNCTION public.activitiestable_select();
       public          postgres    false            �            1255    17972 /   al_insert(character varying, character varying)    FUNCTION     {  CREATE FUNCTION public.al_insert(_user_id character varying, _activities_id character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	INSERT INTO public.calories_intake_list(
    calories_intake_id, date, user_id, activities_id)
	VALUES 
    (nextval(al_id), current_date, _user_id, _activities_id);

	if found then
		return 1;
	else 
		return 0;
	end if;
end
$$;
 ^   DROP FUNCTION public.al_insert(_user_id character varying, _activities_id character varying);
       public          postgres    false                       1255    17983 0   alt_insert(character varying, character varying)    FUNCTION     �  CREATE FUNCTION public.alt_insert(_user_id character varying, _activities_id character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
DECLARE
    new_id INT;
BEGIN
    INSERT INTO public.activities_list(
        activities_list_id, date, user_id, activities_id
    )
    VALUES (
        nextval('as_id'), current_date, _user_id, _activities_id
    )
    RETURNING activities_list_id INTO new_id;

    IF FOUND THEN
        RETURN new_id;
    ELSE
        RETURN 0;
    END IF;
END;
$$;
 _   DROP FUNCTION public.alt_insert(_user_id character varying, _activities_id character varying);
       public          postgres    false                       1255    17955    alt_select_day1()    FUNCTION     (  CREATE FUNCTION public.alt_select_day1() RETURNS TABLE(_activities_list_id character varying, _user_name character varying, _activities_name character varying, _calories_burned character varying)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	SELECT al.activities_list_id, users.user_name, activities.activities_name, activities.calories_burned
	FROM activities_list al
	JOIN users ON al.user_id = users.user_id
	JOIN activities ON al.activities_id = activities.activities_id
	WHERE al.date = current_date
	ORDER BY al.activities_list_id;
end
$$;
 (   DROP FUNCTION public.alt_select_day1();
       public          postgres    false                       1255    17954    alt_select_day2()    FUNCTION     ,  CREATE FUNCTION public.alt_select_day2() RETURNS TABLE(_activities_list_id character varying, _user_name character varying, _activities_name character varying, _calories_burned character varying)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	SELECT al.activities_list_id, users.user_name, activities.activities_name, activities.calories_burned
	FROM activities_list al
	JOIN users ON al.user_id = users.user_id
	JOIN activities ON al.activities_id = activities.activities_id
	WHERE al.date = current_date - 1
	ORDER BY al.activities_list_id;
end
$$;
 (   DROP FUNCTION public.alt_select_day2();
       public          postgres    false                       1255    17953    alt_select_day3()    FUNCTION     ,  CREATE FUNCTION public.alt_select_day3() RETURNS TABLE(_activities_list_id character varying, _user_name character varying, _activities_name character varying, _calories_burned character varying)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	SELECT al.activities_list_id, users.user_name, activities.activities_name, activities.calories_burned
	FROM activities_list al
	JOIN users ON al.user_id = users.user_id
	JOIN activities ON al.activities_id = activities.activities_id
	WHERE al.date = current_date - 2
	ORDER BY al.activities_list_id;
end
$$;
 (   DROP FUNCTION public.alt_select_day3();
       public          postgres    false            
           1255    17952    alt_select_day4()    FUNCTION     ,  CREATE FUNCTION public.alt_select_day4() RETURNS TABLE(_activities_list_id character varying, _user_name character varying, _activities_name character varying, _calories_burned character varying)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	SELECT al.activities_list_id, users.user_name, activities.activities_name, activities.calories_burned
	FROM activities_list al
	JOIN users ON al.user_id = users.user_id
	JOIN activities ON al.activities_id = activities.activities_id
	WHERE al.date = current_date - 3
	ORDER BY al.activities_list_id;
end
$$;
 (   DROP FUNCTION public.alt_select_day4();
       public          postgres    false            	           1255    17951    alt_select_day5()    FUNCTION     ,  CREATE FUNCTION public.alt_select_day5() RETURNS TABLE(_activities_list_id character varying, _user_name character varying, _activities_name character varying, _calories_burned character varying)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	SELECT al.activities_list_id, users.user_name, activities.activities_name, activities.calories_burned
	FROM activities_list al
	JOIN users ON al.user_id = users.user_id
	JOIN activities ON al.activities_id = activities.activities_id
	WHERE al.date = current_date - 4
	ORDER BY al.activities_list_id;
end
$$;
 (   DROP FUNCTION public.alt_select_day5();
       public          postgres    false                       1255    17950    alt_select_day6()    FUNCTION     ,  CREATE FUNCTION public.alt_select_day6() RETURNS TABLE(_activities_list_id character varying, _user_name character varying, _activities_name character varying, _calories_burned character varying)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	SELECT al.activities_list_id, users.user_name, activities.activities_name, activities.calories_burned
	FROM activities_list al
	JOIN users ON al.user_id = users.user_id
	JOIN activities ON al.activities_id = activities.activities_id
	WHERE al.date = current_date - 5
	ORDER BY al.activities_list_id;
end
$$;
 (   DROP FUNCTION public.alt_select_day6();
       public          postgres    false            �            1255    17949    alt_select_day7()    FUNCTION     ,  CREATE FUNCTION public.alt_select_day7() RETURNS TABLE(_activities_list_id character varying, _user_name character varying, _activities_name character varying, _calories_burned character varying)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	SELECT al.activities_list_id, users.user_name, activities.activities_name, activities.calories_burned
	FROM activities_list al
	JOIN users ON al.user_id = users.user_id
	JOIN activities ON al.activities_id = activities.activities_id
	WHERE al.date = current_date - 6
	ORDER BY al.activities_list_id;
end
$$;
 (   DROP FUNCTION public.alt_select_day7();
       public          postgres    false                       1255    17984    at_delete(character varying)    FUNCTION     �   CREATE FUNCTION public.at_delete(_activities_list_id character varying) RETURNS void
    LANGUAGE plpgsql
    AS $$
BEGIN
    DELETE FROM activities_list
    WHERE activities_list_id = _activities_list_id;
END;
$$;
 G   DROP FUNCTION public.at_delete(_activities_list_id character varying);
       public          postgres    false            �            1255    17982 /   at_insert(character varying, character varying)    FUNCTION     �  CREATE FUNCTION public.at_insert(_user_id character varying, _activities_id character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
DECLARE
    new_id INT;
BEGIN
    INSERT INTO public.calories_intake_list(
        activities_list_id, date, user_id, activities_id
    )
    VALUES (
        nextval('as_id'), current_date, _user_id, _activities_id
    )
    RETURNING activities_list_id INTO new_id;

    IF FOUND THEN
        RETURN new_id;
    ELSE
        RETURN 0;
    END IF;
END;
$$;
 ^   DROP FUNCTION public.at_insert(_user_id character varying, _activities_id character varying);
       public          postgres    false            �            1255    17938    at_select()    FUNCTION       CREATE FUNCTION public.at_select() RETURNS TABLE(_activitiesid character varying, _activitiesname character varying, _caloriesburned smallint)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	select activitiesID, activitiesName, caloriesBurned from Activities;
end
$$;
 "   DROP FUNCTION public.at_select();
       public          postgres    false                       1255    17988 /   at_update(character varying, character varying)    FUNCTION     �  CREATE FUNCTION public.at_update(_activities_list_id character varying, _activities_id character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
DECLARE
    updated_id INT;
BEGIN
    UPDATE public.activities_list
    SET
        activities_id = _activities_id,
		date = current_date
    WHERE
        activities_list_id = _activities_list_id
    RETURNING activities_list_id INTO updated_id;

    IF FOUND THEN
        RETURN updated_id;
    ELSE
        RETURN 0;
    END IF;
END;
$$;
 i   DROP FUNCTION public.at_update(_activities_list_id character varying, _activities_id character varying);
       public          postgres    false            �            1255    17968 0   cil_insert(character varying, character varying)    FUNCTION     k  CREATE FUNCTION public.cil_insert(_user_id character varying, _food_id character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	INSERT INTO public.calories_intake_list(
    calories_intake_id, date, user_id, food_id)
	VALUES 
    (nextval(cil_id), current_date, _user_id, _food_id);

	if found then
		return 1;
	else 
		return 0;
	end if;
end
$$;
 Y   DROP FUNCTION public.cil_insert(_user_id character varying, _food_id character varying);
       public          postgres    false            �            1255    17942    cilt_select_day1()    FUNCTION     �  CREATE FUNCTION public.cilt_select_day1() RETURNS TABLE(_calories_intake_id character varying, _user_name character varying, _food_name character varying, _calories character varying)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	SELECT cil.calories_intake_id, users.user_name, food.food_name, food.calories
	FROM calories_intake_list cil
	JOIN users ON cil.user_id = users.user_id
	JOIN food ON cil.food_id = food.food_id
	WHERE cil.date = current_date
	ORDER BY cil.calories_intake_id;
end
$$;
 )   DROP FUNCTION public.cilt_select_day1();
       public          postgres    false            �            1255    17943    cilt_select_day2()    FUNCTION     �  CREATE FUNCTION public.cilt_select_day2() RETURNS TABLE(_calories_intake_id character varying, _user_name character varying, _food_name character varying, _calories character varying)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	SELECT cil.calories_intake_id, users.user_name, food.food_name, food.calories
	FROM calories_intake_list cil
	JOIN users ON cil.user_id = users.user_id
	JOIN food ON cil.food_id = food.food_id
	WHERE cil.date = current_date - 1
	ORDER BY cil.calories_intake_id;
end
$$;
 )   DROP FUNCTION public.cilt_select_day2();
       public          postgres    false            �            1255    17944    cilt_select_day3()    FUNCTION     �  CREATE FUNCTION public.cilt_select_day3() RETURNS TABLE(_calories_intake_id character varying, _user_name character varying, _food_name character varying, _calories character varying)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	SELECT cil.calories_intake_id, users.user_name, food.food_name, food.calories
	FROM calories_intake_list cil
	JOIN users ON cil.user_id = users.user_id
	JOIN food ON cil.food_id = food.food_id
	WHERE cil.date = current_date - 2
	ORDER BY cil.calories_intake_id;
end
$$;
 )   DROP FUNCTION public.cilt_select_day3();
       public          postgres    false            �            1255    17945    cilt_select_day4()    FUNCTION     �  CREATE FUNCTION public.cilt_select_day4() RETURNS TABLE(_calories_intake_id character varying, _user_name character varying, _food_name character varying, _calories character varying)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	SELECT cil.calories_intake_id, users.user_name, food.food_name, food.calories
	FROM calories_intake_list cil
	JOIN users ON cil.user_id = users.user_id
	JOIN food ON cil.food_id = food.food_id
	WHERE cil.date = current_date - 3
	ORDER BY cil.calories_intake_id;
end
$$;
 )   DROP FUNCTION public.cilt_select_day4();
       public          postgres    false            �            1255    17946    cilt_select_day5()    FUNCTION     �  CREATE FUNCTION public.cilt_select_day5() RETURNS TABLE(_calories_intake_id character varying, _user_name character varying, _food_name character varying, _calories character varying)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	SELECT cil.calories_intake_id, users.user_name, food.food_name, food.calories
	FROM calories_intake_list cil
	JOIN users ON cil.user_id = users.user_id
	JOIN food ON cil.food_id = food.food_id
	WHERE cil.date = current_date - 4
	ORDER BY cil.calories_intake_id;
end
$$;
 )   DROP FUNCTION public.cilt_select_day5();
       public          postgres    false            �            1255    17947    cilt_select_day6()    FUNCTION     �  CREATE FUNCTION public.cilt_select_day6() RETURNS TABLE(_calories_intake_id character varying, _user_name character varying, _food_name character varying, _calories character varying)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	SELECT cil.calories_intake_id, users.user_name, food.food_name, food.calories
	FROM calories_intake_list cil
	JOIN users ON cil.user_id = users.user_id
	JOIN food ON cil.food_id = food.food_id
	WHERE cil.date = current_date - 5
	ORDER BY cil.calories_intake_id;
end
$$;
 )   DROP FUNCTION public.cilt_select_day6();
       public          postgres    false            �            1255    17948    cilt_select_day7()    FUNCTION     �  CREATE FUNCTION public.cilt_select_day7() RETURNS TABLE(_calories_intake_id character varying, _user_name character varying, _food_name character varying, _calories character varying)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	SELECT cil.calories_intake_id, users.user_name, food.food_name, food.calories
	FROM calories_intake_list cil
	JOIN users ON cil.user_id = users.user_id
	JOIN food ON cil.food_id = food.food_id
	WHERE cil.date = current_date - 6
	ORDER BY cil.calories_intake_id;
end
$$;
 )   DROP FUNCTION public.cilt_select_day7();
       public          postgres    false                       1255    17987 0   cit_update(character varying, character varying)    FUNCTION     �  CREATE FUNCTION public.cit_update(_calories_intake_id character varying, _food_id character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
DECLARE
    updated_id INT;
BEGIN
    UPDATE public.calories_intake_list
    SET
        food_id = _food_id,
		date = current_date
    WHERE
        calories_intake_id = _calories_intake_id
    RETURNING calories_intake_id INTO updated_id;

    IF FOUND THEN
        RETURN updated_id;
    ELSE
        RETURN 0;
    END IF;
END;
$$;
 d   DROP FUNCTION public.cit_update(_calories_intake_id character varying, _food_id character varying);
       public          postgres    false            �            1255    17971 /   cl_insert(character varying, character varying)    FUNCTION     i  CREATE FUNCTION public.cl_insert(_user_id character varying, _food_id character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	INSERT INTO public.calories_intake_list(
    calories_intake_id, date, user_id, food_id)
	VALUES 
    (nextval(cl_id), current_date, _user_id, _food_id);

	if found then
		return 1;
	else 
		return 0;
	end if;
end
$$;
 X   DROP FUNCTION public.cl_insert(_user_id character varying, _food_id character varying);
       public          postgres    false                       1255    17985    ct_delete(character varying)    FUNCTION     �   CREATE FUNCTION public.ct_delete(_calories_intake_id character varying) RETURNS void
    LANGUAGE plpgsql
    AS $$
BEGIN
    DELETE FROM calories_intake_list
    WHERE calories_intake_id = _calories_intake_id;
END;
$$;
 G   DROP FUNCTION public.ct_delete(_calories_intake_id character varying);
       public          postgres    false            �            1255    17981 /   ct_insert(character varying, character varying)    FUNCTION     �  CREATE FUNCTION public.ct_insert(_user_id character varying, _food_id character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
DECLARE
    new_id INT;
BEGIN
    INSERT INTO public.calories_intake_list(
        calories_intake_id, date, user_id, food_id
    )
    VALUES (
        nextval('cs_id'), current_date, _user_id, _food_id
    )
    RETURNING calories_intake_id INTO new_id;

    IF FOUND THEN
        RETURN new_id;
    ELSE
        RETURN 0;
    END IF;
END;
$$;
 X   DROP FUNCTION public.ct_insert(_user_id character varying, _food_id character varying);
       public          postgres    false                       1255    17986 B   ct_update(character varying, character varying, character varying)    FUNCTION       CREATE FUNCTION public.ct_update(_calories_intake_id character varying, _user_id character varying, _food_id character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
DECLARE
    updated_id INT;
BEGIN
    UPDATE public.calories_intake_list
    SET
        user_id = _user_id,
        food_id = _food_id,
		date = current_date
    WHERE
        calories_intake_id = _calories_intake_id
    RETURNING calories_intake_id INTO updated_id;

    IF FOUND THEN
        RETURN updated_id;
    ELSE
        RETURN 0;
    END IF;
END;
$$;
    DROP FUNCTION public.ct_update(_calories_intake_id character varying, _user_id character varying, _food_id character varying);
       public          postgres    false            �            1255    17940    foodtable_select()    FUNCTION     �   CREATE FUNCTION public.foodtable_select() RETURNS TABLE(_food_id character varying, _food_name character varying, _calories smallint)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	select food_id, food_name, calories from food;
end
$$;
 )   DROP FUNCTION public.foodtable_select();
       public          postgres    false            �            1255    17939    ft_select()    FUNCTION     �   CREATE FUNCTION public.ft_select() RETURNS TABLE(_foodid character varying, _foodname character varying, _calories smallint)
    LANGUAGE plpgsql
    AS $$
begin
	return query
	select foodID, foodName, calories from Food;
end
$$;
 "   DROP FUNCTION public.ft_select();
       public          postgres    false            �            1255    17977 _   u_insert(character varying, smallint, smallint, smallint, character varying, character varying)    FUNCTION     �  CREATE FUNCTION public.u_insert(_user_name character varying, _weight smallint, _height smallint, _age smallint, _gender character varying, _password character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	INSERT INTO public.users(
    user_id, user_name, weight, height, age, gender, password)
	VALUES 
    (nextval(u_id), _user_name, _weight, _height, _age, _gender, _password);

	if found then
		return 1;
	else 
		return 0;
	end if;
end
$$;
 �   DROP FUNCTION public.u_insert(_user_name character varying, _weight smallint, _height smallint, _age smallint, _gender character varying, _password character varying);
       public          postgres    false                       1255    17978 b   user_insert(character varying, smallint, smallint, smallint, character varying, character varying)    FUNCTION     :  CREATE FUNCTION public.user_insert(_user_name character varying, _weight smallint, _height smallint, _age smallint, _gender character varying, _password character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
DECLARE
    new_id INT;
BEGIN
    INSERT INTO public.users(
        user_id, user_name, weight, height, age, gender, password)
    VALUES (
        nextval('u_id'), _user_name, _weight, _height, _age, _gender, _password
    )
    RETURNING user_id INTO new_id;

    IF FOUND THEN
        RETURN new_id;
    ELSE
        RETURN 0;
    END IF;
END;
$$;
 �   DROP FUNCTION public.user_insert(_user_name character varying, _weight smallint, _height smallint, _age smallint, _gender character varying, _password character varying);
       public          postgres    false            �            1259    17975    a_id    SEQUENCE     m   CREATE SEQUENCE public.a_id
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
    DROP SEQUENCE public.a_id;
       public          postgres    false            �            1259    17893 
   activities    TABLE     �   CREATE TABLE public.activities (
    activities_id character varying(50) NOT NULL,
    activities_name character varying(50) NOT NULL,
    calories_burned smallint NOT NULL
);
    DROP TABLE public.activities;
       public         heap    postgres    false            �            1259    17905    activities_list    TABLE     �   CREATE TABLE public.activities_list (
    activities_list_id character varying(50) NOT NULL,
    date date NOT NULL,
    user_id character varying(50) NOT NULL,
    activities_id character varying(50) NOT NULL
);
 #   DROP TABLE public.activities_list;
       public         heap    postgres    false            �            1259    17898    activitiesid    SEQUENCE     u   CREATE SEQUENCE public.activitiesid
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.activitiesid;
       public          postgres    false            �            1259    17920    activitieslistid    SEQUENCE     y   CREATE SEQUENCE public.activitieslistid
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.activitieslistid;
       public          postgres    false            �            1259    17969    al_id    SEQUENCE     n   CREATE SEQUENCE public.al_id
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
    DROP SEQUENCE public.al_id;
       public          postgres    false            �            1259    17980    as_id    SEQUENCE     n   CREATE SEQUENCE public.as_id
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
    DROP SEQUENCE public.as_id;
       public          postgres    false            �            1259    17974    c_id    SEQUENCE     m   CREATE SEQUENCE public.c_id
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
    DROP SEQUENCE public.c_id;
       public          postgres    false            �            1259    17921    calories_intake_list    TABLE     �   CREATE TABLE public.calories_intake_list (
    calories_intake_id character varying(50) NOT NULL,
    date date NOT NULL,
    user_id character varying(50) NOT NULL,
    food_id character varying(50) NOT NULL
);
 (   DROP TABLE public.calories_intake_list;
       public         heap    postgres    false            �            1259    17936    caloriesintakeid    SEQUENCE     y   CREATE SEQUENCE public.caloriesintakeid
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.caloriesintakeid;
       public          postgres    false            �            1259    17967    cil_id    SEQUENCE     o   CREATE SEQUENCE public.cil_id
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
    DROP SEQUENCE public.cil_id;
       public          postgres    false            �            1259    17970    cl_id    SEQUENCE     n   CREATE SEQUENCE public.cl_id
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
    DROP SEQUENCE public.cl_id;
       public          postgres    false            �            1259    17979    cs_id    SEQUENCE     n   CREATE SEQUENCE public.cs_id
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
    DROP SEQUENCE public.cs_id;
       public          postgres    false            �            1259    17881    food    TABLE     �   CREATE TABLE public.food (
    food_id character varying(50) NOT NULL,
    food_name character varying(50) NOT NULL,
    calories smallint NOT NULL
);
    DROP TABLE public.food;
       public         heap    postgres    false            �            1259    17886    foodid    SEQUENCE     o   CREATE SEQUENCE public.foodid
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
    DROP SEQUENCE public.foodid;
       public          postgres    false            �            1259    17937    sadasdsakeid    SEQUENCE     u   CREATE SEQUENCE public.sadasdsakeid
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.sadasdsakeid;
       public          postgres    false            �            1259    17973    u_id    SEQUENCE     m   CREATE SEQUENCE public.u_id
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
    DROP SEQUENCE public.u_id;
       public          postgres    false            �            1259    17904    userid    SEQUENCE     o   CREATE SEQUENCE public.userid
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
    DROP SEQUENCE public.userid;
       public          postgres    false            �            1259    17899    users    TABLE     '  CREATE TABLE public.users (
    user_id character varying(50) NOT NULL,
    user_name character varying(50) NOT NULL,
    weight smallint NOT NULL,
    height smallint NOT NULL,
    age smallint NOT NULL,
    gender character varying(10) NOT NULL,
    password character varying(20) NOT NULL
);
    DROP TABLE public.users;
       public         heap    postgres    false            �            1259    17892 	   workoutid    SEQUENCE     r   CREATE SEQUENCE public.workoutid
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
     DROP SEQUENCE public.workoutid;
       public          postgres    false            A          0    17893 
   activities 
   TABLE DATA           U   COPY public.activities (activities_id, activities_name, calories_burned) FROM stdin;
    public          postgres    false    217   F�       E          0    17905    activities_list 
   TABLE DATA           [   COPY public.activities_list (activities_list_id, date, user_id, activities_id) FROM stdin;
    public          postgres    false    221   ��       G          0    17921    calories_intake_list 
   TABLE DATA           Z   COPY public.calories_intake_list (calories_intake_id, date, user_id, food_id) FROM stdin;
    public          postgres    false    223   �       >          0    17881    food 
   TABLE DATA           <   COPY public.food (food_id, food_name, calories) FROM stdin;
    public          postgres    false    214   8�       C          0    17899    users 
   TABLE DATA           Z   COPY public.users (user_id, user_name, weight, height, age, gender, password) FROM stdin;
    public          postgres    false    219   �       X           0    0    a_id    SEQUENCE SET     3   SELECT pg_catalog.setval('public.a_id', 1, false);
          public          postgres    false    231            Y           0    0    activitiesid    SEQUENCE SET     ;   SELECT pg_catalog.setval('public.activitiesid', 1, false);
          public          postgres    false    218            Z           0    0    activitieslistid    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.activitieslistid', 1, false);
          public          postgres    false    222            [           0    0    al_id    SEQUENCE SET     3   SELECT pg_catalog.setval('public.al_id', 1, true);
          public          postgres    false    227            \           0    0    as_id    SEQUENCE SET     3   SELECT pg_catalog.setval('public.as_id', 9, true);
          public          postgres    false    233            ]           0    0    c_id    SEQUENCE SET     3   SELECT pg_catalog.setval('public.c_id', 1, false);
          public          postgres    false    230            ^           0    0    caloriesintakeid    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.caloriesintakeid', 1, false);
          public          postgres    false    224            _           0    0    cil_id    SEQUENCE SET     4   SELECT pg_catalog.setval('public.cil_id', 3, true);
          public          postgres    false    226            `           0    0    cl_id    SEQUENCE SET     3   SELECT pg_catalog.setval('public.cl_id', 1, true);
          public          postgres    false    228            a           0    0    cs_id    SEQUENCE SET     3   SELECT pg_catalog.setval('public.cs_id', 9, true);
          public          postgres    false    232            b           0    0    foodid    SEQUENCE SET     5   SELECT pg_catalog.setval('public.foodid', 1, false);
          public          postgres    false    215            c           0    0    sadasdsakeid    SEQUENCE SET     ;   SELECT pg_catalog.setval('public.sadasdsakeid', 1, false);
          public          postgres    false    225            d           0    0    u_id    SEQUENCE SET     3   SELECT pg_catalog.setval('public.u_id', 10, true);
          public          postgres    false    229            e           0    0    userid    SEQUENCE SET     5   SELECT pg_catalog.setval('public.userid', 1, false);
          public          postgres    false    220            f           0    0 	   workoutid    SEQUENCE SET     8   SELECT pg_catalog.setval('public.workoutid', 1, false);
          public          postgres    false    216            �           2606    17909 $   activities_list Activities List_pkey 
   CONSTRAINT     t   ALTER TABLE ONLY public.activities_list
    ADD CONSTRAINT "Activities List_pkey" PRIMARY KEY (activities_list_id);
 P   ALTER TABLE ONLY public.activities_list DROP CONSTRAINT "Activities List_pkey";
       public            postgres    false    221            �           2606    17897    activities Activities_pkey 
   CONSTRAINT     e   ALTER TABLE ONLY public.activities
    ADD CONSTRAINT "Activities_pkey" PRIMARY KEY (activities_id);
 F   ALTER TABLE ONLY public.activities DROP CONSTRAINT "Activities_pkey";
       public            postgres    false    217            �           2606    17925 .   calories_intake_list Calories Intake List_pkey 
   CONSTRAINT     ~   ALTER TABLE ONLY public.calories_intake_list
    ADD CONSTRAINT "Calories Intake List_pkey" PRIMARY KEY (calories_intake_id);
 Z   ALTER TABLE ONLY public.calories_intake_list DROP CONSTRAINT "Calories Intake List_pkey";
       public            postgres    false    223            �           2606    17885    food Food_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY public.food
    ADD CONSTRAINT "Food_pkey" PRIMARY KEY (food_id);
 :   ALTER TABLE ONLY public.food DROP CONSTRAINT "Food_pkey";
       public            postgres    false    214            �           2606    17903    users User_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.users
    ADD CONSTRAINT "User_pkey" PRIMARY KEY (user_id);
 ;   ALTER TABLE ONLY public.users DROP CONSTRAINT "User_pkey";
       public            postgres    false    219            �           2606    17915 1   activities_list Activities List_activitiesID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.activities_list
    ADD CONSTRAINT "Activities List_activitiesID_fkey" FOREIGN KEY (activities_id) REFERENCES public.activities(activities_id) MATCH FULL;
 ]   ALTER TABLE ONLY public.activities_list DROP CONSTRAINT "Activities List_activitiesID_fkey";
       public          postgres    false    221    217    3237            �           2606    17910 +   activities_list Activities List_userID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.activities_list
    ADD CONSTRAINT "Activities List_userID_fkey" FOREIGN KEY (user_id) REFERENCES public.users(user_id) MATCH FULL;
 W   ALTER TABLE ONLY public.activities_list DROP CONSTRAINT "Activities List_userID_fkey";
       public          postgres    false    219    221    3239            �           2606    17931 5   calories_intake_list Calories Intake List_foodID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.calories_intake_list
    ADD CONSTRAINT "Calories Intake List_foodID_fkey" FOREIGN KEY (food_id) REFERENCES public.food(food_id) MATCH FULL;
 a   ALTER TABLE ONLY public.calories_intake_list DROP CONSTRAINT "Calories Intake List_foodID_fkey";
       public          postgres    false    223    214    3235            �           2606    17926 5   calories_intake_list Calories Intake List_userID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.calories_intake_list
    ADD CONSTRAINT "Calories Intake List_userID_fkey" FOREIGN KEY (user_id) REFERENCES public.users(user_id) MATCH FULL;
 a   ALTER TABLE ONLY public.calories_intake_list DROP CONSTRAINT "Calories Intake List_userID_fkey";
       public          postgres    false    223    219    3239            A   M  x�mV]s�6}&��?Ў��G;mr'O�6���,X��
є���J������ꜳgD�(>˶�C���]l�ٙ!�gg�A�����0��#�nXc���i����$����@��!�q)�LɚwA�E��E�X1<���H�X�0����\�Xy�a"h��,\+��Q<������ׂ��$�F.��(�����Ӡ��.J��	��pn�f��>��p-�7l���zB�G2*Q��MW�?匈��ܸ窛�6�#C�����G#s�Z7R��0vL۾D�/OO#H��C��n���;I�8Y����`<���՞�d��>�����<��������äGG��8@l�	�_�[Vw�1vߦ��M��Q��o�!����2����$v�ad��;��)N&x�Җ���t)y��8>��B�pI!���E�8�7�����R�bW����*[w��ⰤZ^߉Y�L+ޘ⩣�(�7�4Z�P@8��в��)S���l�?x���;h���L3�6Zy�:u,_�!i�-嘢i���:��n@)f����[T}J�3G�a�bӱ��"���Q}�pdaz�o�x��@urR�W��z�(�L=��P=�9�{̊��)��Us�*��鰊�JV���Z0�MN⛕�/�����t��b�W�5^�0��e���B�h,��ކ1nx/�A����9\����ԟ��g�$E��;(M�٢��c�x�F��8@�������uV�N��<4'%�;�������?+�iF᫴���a:[��X%�?Mv2��:T|�ErC�u�׳a_�7^��Ҧ�7�2o
���R���E�/c���)��5�1RW!�����^�R��^\)$��p�6I��
@�[t�i�_L�lC�tz�*4�[;��Y�x�hC��UV���� -3���y5(�(�d���Yx�t<
�$R�T�Q�w��-+�E1�����ju�O����Fx�à9��Q�['TN��'���sS9A^����WޗdRKӪ�Z$~R�����0��$BU���g-����P�W�g�M�I���u��[˟�juÕ�
�gh���������      E   6   x�3�4202�54�54�4�4�2F�q� ̐@*�Q͹,єs��qqq ��d      G   ?   x�]˹� �X��܋��2[�;�j�l��?`,���9�b^�*ӱ�x�� 65�T      >   �  x�]U˒�8<�_�HJ�<�N*5��������\��]zԔ����ĳ�I@wh���V�p��k�Q�J����SJ'�8�Y�J�^�~@B�̇>�����9��ɩ�;H�\ �T3��)Ŕp�a�6��l��ԍ#x6��4R,�}l �P������_������8bk�~B��]?��V[�Q6u0WHJ���<��h:O<���y�BL�GF��`�I��P�AS�$�����t0����T�;aҨ�dE�������@s �1��(H7:��j�ѴΓ�1<ۇ%T������!�L[��s6-�n7�x�^��~M�|ᇐ�9l��4K�����Y~b=�p0����8�W�:a�+j�Mm�� �9��e~#�[��A�4�9Z����"�7W�A�M5<�H��;��,�tQ�^E�4L����P�!%`i���hb>j���Gw�K������N�;�`=ڞ���A�,
K1_��,�=O� Mɒ�s�W���fF�*����L�?��ĲtY����i&�o恓ҁ��#^g巄C�گ�u�"���̪2�<��|�q�0���+&R������I�r�����KNS=�Vx���ϗyXʼ���Z����%�v3S�x����<�Z��՟]'�b5��6�H�%8`/VCP��ڛ�'ޢa�fs 7G2֢ ��	X�"�C�q��	ŧ�)�O����d����2�-��l�ȻM�{�8v��<���	��Ȝ�޼����:���2�e���b3��]f�ȯ��|�ɘ�}X38_���R��Qd+C/vsO��t7^��8�B���^ǹ����U�`Y�X�J���d=3�OM��m���*�5Q�U�z�bt�����L�bj͈Z3���z�J��͘ly��:
���o��?�fg7
Ǹ���,�T?y˧^��V>Z�|]�V�`�      C   �   x�}���0����T��@F�2U�T�.�������/)�v���>��,���'H!�>�+�vSI��qD) ��ll��N���M7�>z+6�X7�BgT-{>n�6��`)G|ـ,�
�N*�ێ(���ڬO�D5D��ݶ52p.uM,;�s$��~L��ǉ�޲�F�     