using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhamasySystem2.Model;

namespace PhamasySystem2.MedicinesData
{
    public class MockMedicinesData : IMedicines
    {

        private List<Medicines> medicines = new List<Medicines>()
        {
            new Medicines()
            {
                Id = Guid.NewGuid(),
                Name = "Janitha Tharaka",
                CompanyName="nicholas",
                Disease="body pain",
                Amount=20.00
            },
             new Medicines()
             { Id=Guid.NewGuid(),
               Name ="omphalos",
               CompanyName ="Omphalos Bioscience LLC",
               Disease ="gastritis",
               Amount =40.00
             }
        };

        public Medicines AddMedicine(Medicines medicine)
        {
            medicine.Id = Guid.NewGuid();
            medicines.Add(medicine);
            return medicine;
        }

        public void DeleteMedicine(Medicines medicine)
        {
            medicines.Remove(medicine);
        }

        public Medicines EditMedicine(Medicines medicine)
        {
            var exixingMedicine = GetMedicine(medicine.Id);
            exixingMedicine.Name = medicine.Name;
            exixingMedicine.CompanyName = medicine.CompanyName;
            exixingMedicine.Disease = medicine.Disease;
            exixingMedicine.Amount = medicine.Amount;
            return exixingMedicine;
        }

        public Medicines GetMedicine(Guid id)
        {
            return medicines.SingleOrDefault(x => x.Id == id);
        }

        public List<Medicines> GetMedicines()
        {
            return medicines;
        }
    }
}
