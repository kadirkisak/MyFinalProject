using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi...";
        public static string ProductNameInvalid = "Ürün ismi geçersiz...";
        public static string MaintenanceTime = "Bakım saati nedeniyle liste oluşturulmadı...";
        public static string ProductsListed = "Ürünler listelendi...";
        public static string ProductCountOfCategoryError = "Kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Aynı isimde ürün bulunmaktadır.";
        public static string CategoryLimitExceded="Kategori limiti aşıldı...";
        public static string AuthorizationDenied="Yetkiniz yoktur...";
        public static string UserRegistered="Kayıt başarılı...";
        public static string UserNotFound="Kullanıcı bulunamadı..";
        public static string PasswordError="Password hatası..";
        internal static string SuccessfulLogin="Giriş başarılı";
        public static string UserAlreadyExists="Kullanıcı zaten var";
        public static string AccessTokenCreated="Giriş anahtarı oluşturuldu..";
    }
}
