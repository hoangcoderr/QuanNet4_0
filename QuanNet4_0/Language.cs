using System;
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
        public static string[] cannotConnectToServer = { "Không thể kết nối đến server. Vui lòng kiểm tra lại đường truyền", "Can't connect to server. Please check your internet connection!" };
        public static string[] nameText = { "Tên", "Name" };
        public static string[] yesNoTurnOff = { "Bạn có chắc chắn muốn thoát không?", "Do you want to close the application?" };
        public static string[] yesText = { "Có", "Yes" };
        public static string[] noText = { "Không", "No" };
        public static string[] alreadyConnectedToServer = { "Bạn đã kết nối đến server rồi", "You've already connected to server!" };
        public static string[] welcomeText = { "Chào mừng,", "Welcome," };
        public static string[] amountText = { "Số dư: ", "Amount: " };
        public static string[] notEnoughMoney = { "Bạn không đủ tiền để mua item này!", "You don't have enough money to pay this item!" };
        public static string[] buySucessfully = { "Bạn đã mua thành công!", "Pay sucessfully!" };
        public static string[] notEnoughItemFromServer = { "Xin lỗi, món hàng này hiện đã hết!", "Sorry, this item is temporary out!" };
    }

}
