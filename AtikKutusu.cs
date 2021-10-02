using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtıkOyunu
{
    class AtikKutusu : IAtikKutusu
    {
        private string _tur;
        private int _kapasite;
        private int _doluHacim;

        public AtikKutusu(string tur)
        {
            this._tur = tur;
        }

        public int Kapasite {
            get
            {
                return _kapasite;
            }
            set
            {
                _kapasite = value;
            }
        }

        public int DoluHacim
        {
            get { return _doluHacim; }
        }

        public string Tur
        {
            get { return _tur; }
        }

        public int DolulukOrani
        {
            get
            {
                return (100 * _doluHacim) / _kapasite;
            }
        }

        public int BosaltmaPuani
        {
            get
            {
                if (_tur.Equals("kağıt"))
                    return 1000;
                else if (_tur.Equals("cam"))
                    return 600;
                else if (_tur.Equals("metal"))
                    return 800;
                return 0;
            }
        }

        public bool Bosalt()
        {
            _doluHacim = 0;

            return true;
        }
        public int BosAlan
        {
            get{
                return (_kapasite-_doluHacim);
            }
        }

        public bool Ekle(Atik atik)
        {
            _doluHacim += atik.Hacim;
            return true;
        }
    }
}
