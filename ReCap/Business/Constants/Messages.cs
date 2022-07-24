using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //Car
        public static string CarAdded = "Araç Eklendi";
        public static string CarNameInvalid = "Araç İsmi Geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string CarListed="Araçlar Listelendi";
        public static string CarColorIdListed="Araçlar Renk Sırasına Göre Listelendi";
        public static string CarDeleted="Araç Silinmiştir";
        public static string CarUpdated="Araç Güncellenmiştir";
        //Brand
        public static string BrandNameInvalid="Marka İsmi Geçersiz";
        public static string BrandListed="Markalar Listelendi";
        //Color
        public static string ColorNameInvalid="Renk İsmi Geçersiz";
        public static string ColorListed="Renkler Listelendi";
        //Users
        public static string UsersNotAdded="Kullanıcı Eklenemedi";
        public static string UserAdded="Kullanıcı Eklendi";
        public static string UserDeleted="Kullanıcı Silindi";
        public static string UserUpdated="Kullanıcı Güncellendi";
        public static string UsersListed="Kullanıcılar Listelendi";
        //Customer
        public static string CustomerAdded="Müşteri Eklendi";
        public static string CustomerNotAdded = "Müsteri Eklenemedi";
        public static string CustomerDeleted="Müşteri Silindi";
        public static string CustomerUpdated="Müşteri Güncellendi";
        public static string CustomerListed="Müşteriler Listelendi";
        //Rentals
        public static string RentalsAdded = "Araç Kiralandı";
        public static string RentalsNotAdded = "Araç İade Edilmemiştir";
        public static string RentalsListed = "Kiralık Araçlar Listelenmiştir";
    }
}
