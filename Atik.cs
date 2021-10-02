using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtıkOyunu
{
    public class Atik : IAtik
    {
        private Image _resim;
        private string _tur;
        private int _hacim;
        private string _isim;

        public Atik(Image resim,string tur,int hacim,string isim)
        {
            this._resim = resim;
            this._tur = tur;
            this._hacim = hacim;
            this._isim = isim;
        }
        public int Hacim    // Hacmi döndürür
        {
            get
            {
                return _hacim;
            }
        }

        public string Tur
        {
            get { return _tur; }
        }
        public string Isim          // gerekli bilgileri return eder
        {
            get { return _isim; }
        }
        public Image Resim
        {
            get { return _resim; }
        }
        public Image Image
        {
            get
            {
                return _resim;
            }
        }
    }
}
