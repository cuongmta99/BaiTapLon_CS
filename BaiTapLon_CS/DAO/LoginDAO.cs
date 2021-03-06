﻿using System;
using System.Collections.Generic;
using System.Data;

namespace BaiTapLon_CS.DAO
{
    internal class LoginDAO
    {
        public static string ID_Manager;
        public static string Name_Manager;
        public static LoginDAO instance;
        public static LoginDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    return new LoginDAO();
                }
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public string getID(string email, string password)
        {
            string id = "";
            string query = "SELECT * FROM Manager WHERE Email='" + email + "' and Password='" + password + "'";
            DataTable dt = DAO.DataProvider.Instance.DisplayListView(query);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    id = dr["ID_Manager"].ToString();
                    Name_Manager = dr["Name_Manager"].ToString();
                    ID_Manager = id;

                }

            }
            return id;

        }
        public List<String> getName_Permission(string ID_Permission)
        {
            List<string> key_Permisson = new List<string>();
            string query = "SELECT * FROM Permission WHERE ID_Permission='" + ID_Permission + "'";
            DataTable dt = DAO.DataProvider.Instance.DisplayListView(query);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    key_Permisson.Add(dr["Key_Permission"].ToString());
                }
            }
            return key_Permisson;
        }
        public string getID_Permission(string ID)
        {
            string id_Permission = "";
            string query = "SELECT * FROM Detail_Permission WHERE ID_Manager='" + ID + "'";
            DataTable dt = DAO.DataProvider.Instance.DisplayListView(query);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    id_Permission = dr["ID_Permission"].ToString();
                }
            }
            return id_Permission;
        }
    }
}
