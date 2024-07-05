using DAO;
using DTO;
using System;

namespace BUS
{
    public class AdvertiseBUS
    {
        public static int AddAdvertise(AdvertiseDTO ad, int idCompany)
        {
            return AdvertiseDAO.AddAdvertise(ad, idCompany);
        }



        public static double CaculatePrice(AdvertiseDTO ad, double discountRate)
        {
            TimeSpan duration = ad.EndDate.Subtract(ad.StartDate);
            int daysCount = (int)duration.TotalDays;
            double costPerDay = 50000;
            double typeMultiplier = GetTypeMultiplier(ad.AdType);

            double totalCost = daysCount * costPerDay * typeMultiplier * (1 - discountRate);
            return Math.Round(totalCost, 2);
        }

        private static double GetTypeMultiplier(string adType)
        {
            switch (adType)
            {
                case "Báo Giấy":
                    return 1.5;
                case "Banner Quảng Cáo":
                    return 1.75;
                case "Trang Mạng":
                    return 1.25;
                default:
                    return 1.0;
            }
        }
    }
}
