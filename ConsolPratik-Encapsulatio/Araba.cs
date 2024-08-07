using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolPratik_Encapsulatio
{
    public class Araba
    {
        // Property to hold the car's brand
        // Arabanın markasını tutan özellik
        public string Marka { get; set; }
        // Property to hold the car's color
        // Arabanın rengini tutan özellik
        public int Model { get; set; }
        // Property to hold the car's color
        // Arabanın rengini tutan özellik
        public string Renk { get; set; }
        // Private field to hold the number of doors
        // Kapı sayısını tutan özel alan
        private int _kapısayisi { get; set; }
        // Public property to get and set the number of doors
        // Kapı sayısını alıp ayarlamak için genel özellik
        public int Kapisayisi
        {
            get
            {
                // Return the number of doors
                // Kapı sayısını döndür
                return _kapısayisi;
            }
            set
            {
                // Check if the value is either 2 or 4
                // Değerin 2 veya 4 olup olmadığını kontrol et
                if (value==2 && value==4)
                {
                    // Set the number of doors
                    // Kapı sayısını ayarla
                    _kapısayisi = value;
                }
                else
                {
                    // Set the number of doors to -1 for invalid input
                    // Geçersiz giriş için kapı sayısını -1 olarak ayarla
                    _kapısayisi = -1;
                    // Display a warning message
                    // Uyarı mesajı göster
                    Console.WriteLine("!!!!!!   uyarı kapı sayısı doğru değil kapı sayınız   !!!!!!!!");
                }
            }
        }
    }
}
