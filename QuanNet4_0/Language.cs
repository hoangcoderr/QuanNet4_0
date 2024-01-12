﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanNet4_0
{
    internal class Language
    {
        public static int languageUsing = 0;
        public static string[] isAvaiableAccount = { "Tài khoản đã tồn tại", "Account already exists" };
        public static string[] isFilledAccOrPass = { "Bạn chưa nhập account hoặc password", "You haven't entered an account or password" };
        public static string[] isMatchedPassword = { "Mật khẩu bạn nhập không khớp", "The password you entered does not match" };
        public static string[] notification = { "Thông báo", "Notification" };
        public static string[] loginSucessful = { "Đăng nhập thành công", "Login sucessfully" };
        public static string[] registerSucessful = { "Đăng ký thành công", "Register sucessfully" };
        public static string[] loginText = { "Đăng nhập", "Login" };
        public static string[] passwordText = { "Mật khẩu", "Password" };
        public static string[] usernameText = { "Tài khoản", "Username" };
        public static string[] createAcc = { "Tạo tài khoản", "Create account" };
        public static string[] languages = { "Ngôn ngữ", "Language" };
        public static string[] retypePasswordText = { "Nhập lại mật khẩu", "Retype Password" };
        public static string[] registerText = { "Đăng ký", "Register" };
        public static string[] showPasswordText = { "Hiện mật khẩu", "Show password" };
        public static string[] wrongInformationText = { "Sai tài khoản hoặc mật khẩu", "Wrong username or password" };
    }

}
