using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using static BedayzMobil.Services.RestAPIForProducts;

namespace BedayzMobil.Models
{
    public class Product
    {
        private int _ID, _CategoryId, _NumberInStock, _Adet = 0, _SepetId;
        private string _Name, _Url, _Info, _ImageSource;
        private double _Cost, _PreviousCost, _KargoFiyatı;
        private EMarka _Marka;
        private Category _Category;
        private IList<ImageModel> _Images = new List<ImageModel>();



        public int Id
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public EMarka Marka
        {
            get { return _Marka; }
            set { _Marka = value; }
        }
        public double Cost
        {
            get { return _Cost; }
            set { _Cost = value; }
        }
        public double PreviousCost
        {
            get { return _PreviousCost; }
            set { _PreviousCost = value; }
        }
        public int CategoryId
        {
            get { return _CategoryId; }
            set { _CategoryId = value; }
        }
        public string Url
        {
            get { return _Url; }
            set { _Url = value; }
        }
        public int NumberInStock
        {
            get { return _NumberInStock; }
            set { _NumberInStock = value; }
        }
        public string Info
        {
            get { return _Info; }
            set { _Info = value; }
        }
        public double KargoFiyatı
        {
            get { return _KargoFiyatı; }
            set { _KargoFiyatı = value; }
        }
        public Category Category
        {
            get { return _Category; }
            set { _Category = value; }
        }
        public IList<ImageModel> Images
        {
            get;
            set;

        } = new List<ImageModel>();
        public string ImageSource
        {
            get { return _ImageSource; }
            set { _ImageSource = value; }
        }
        public int Adet
        {
            get { return _Adet; }
            set { _Adet = value; }
        }
        public int SepetId
        {
            get { return _SepetId; }
            set { _SepetId = value; }
        }

        public enum EMarka : byte
        {
            [Description("BEDAYZ")]
            BEDAYZ = 1
        }
    }
}
