using Kodlamaio_BootlegSteam.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlamaio_BootlegSteam.Entities
{
    public class Game:IGame
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        private int Discount;

        public int GetDiscount()
        {
            return Discount;
        }

        public void SetDiscount(int value)
        {
            if (0<=value&&value<=100)
            {
                Discount = value;
                SetFinalPrice(BasePrice - (BasePrice * (Convert.ToDouble(value) / 100)));
            }
            else
            {
                Console.WriteLine("İndirim oranı 0 ve 100 arasında Olmalıdır!");
            }
        }

        public double BasePrice { get; set; }
        //Burada da Ekranda görünen fiyatın
        //Her zaman Baseprice-(Baseprice*(discount/100))
        //olmasını istiyorum ama görünüşe göre onu da
        //yapmayı bilmiyorum(discount 0 ve 100 arasında).
        //Edit: Discount Her Set edildiği zaman
        //FinalPrice'ı set etmeyi deneyeceğim.

        private double FinalPrice;

        public double GetFinalPrice()
        {
            return FinalPrice;
        }

        //Final Price ın sadece discount içinden set edilmesini istiyorum
        //O yüzden private
        private void SetFinalPrice(double value)
        {
            FinalPrice = value;
        }
    }
}
