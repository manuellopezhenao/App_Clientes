﻿using System;
using Datos;

namespace Negocio
{
    public class ClsLogin_Negocio
    {
        public String nombre;
        public int sw = 1;
        protected String usuario, contraseña;
        public void Ftn_Ingresar(String user, String pass)
        {
            usuario = user;
            contraseña = pass;
            Fnt_Login();
        }

        protected void Fnt_Login()
        {
            ClsLogin_Datos ObjConsultar = new ClsLogin_Datos();
            ObjConsultar.Fnt_ConsultarDB(usuario, contraseña);
            nombre = ObjConsultar.nombre;
            sw = ObjConsultar.sw;
        }


    }
}
