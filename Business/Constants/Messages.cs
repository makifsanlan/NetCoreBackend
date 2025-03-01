using Core.Entities.Concrete;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "ürün eklendi";
        public static string ProductNameInvalid = "ürün ismi geçersiz";
        public static string MaintenanceTime = "sistem bakımda";
        public static string ProductsListed = "ürünler listelendi";
        public static string ProductCountOfCategoryError = "bir ürünün kategorisinde en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists="bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded= "kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied="yetkiniz yok";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound= "Kullanıcı bulunamadı";
        public static string PasswordError="Şifre hatalı";
        public static string SuccessfulLogin="Başarılı giriş";
        public static string UserAlreadyExists="Kullanıcı mevcut";
        public static string AccessTokenCreated="Token oluşturuldu";
        public static string ProductUpdated= "Ürün güncellendi";
    }
}
