using System;
using System.Collections.Generic;
using System.Text;

namespace _13112021
{
    class Generic<Tname,Tphone>
    {
        Tphone[] _phones = new Tphone[0];
        Tname[] _names = new Tname[0];
       public void Add(Tname name, Tphone phone)
        {
            Array.Resize(ref _phones, _phones.Length + 1);
            _phones[_phones.Length - 1] = phone;

            Array.Resize(ref _names, _names.Length + 1);
            _names[_names.Length - 1] = name;
        }


        public Tphone[] GetTphone(Tname name)
        {
            Tphone[] neededPhones = new Tphone[0];
            for (int i = 0; i < _names.Length; i++)
            {
                if (_names[i].Equals(name))
                {
                    Array.Resize(ref neededPhones, neededPhones.Length + 1);
                    neededPhones[neededPhones.Length - 1] = _phones[i];
                }
            }
            return _phones;
        }


        public Tname Getname(Tphone phone)
        {
            for (int i = 0; i < _phones.Length; i++)
            {
                if (_phones[i].Equals(phone))
                {
                    return _names[i];
                }
            }
            throw new Exception("Bele bir nomre yoxdur");
        }
        
    }
}
