using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhamasySystem2.Model;

namespace PhamasySystem2.MedicinesData
{
    public class SqlMedicinesData : IMedicines
    {

        private MedicineContext _medicineContext;
        public SqlMedicinesData(MedicineContext medicineContext)
        {
            _medicineContext = medicineContext;
        }
        public Medicines AddMedicine(Medicines medicine)
        {
            medicine.Id = Guid.NewGuid();
            _medicineContext.Medicines.Add(medicine);
            _medicineContext.SaveChanges();
            return medicine;
        }

        public void DeleteMedicine(Medicines medicine)
        {
            _medicineContext.Medicines.Remove(medicine);
            _medicineContext.SaveChanges();
        }

        public Medicines EditMedicine(Medicines medicine)
        {
            var exixtingMedicine = _medicineContext.Medicines.Find(medicine.Id);
            if(exixtingMedicine != null)
            {

                exixtingMedicine.Name = medicine.Name;
                exixtingMedicine.CompanyName = medicine.CompanyName;
                exixtingMedicine.Disease = medicine.Disease;
                exixtingMedicine.Amount = medicine.Amount;
                _medicineContext.Medicines.Update(exixtingMedicine);
                _medicineContext.SaveChanges();

            }
            return medicine;

        }

        public Medicines GetMedicine(Guid id)
        {
            var medicine = _medicineContext.Medicines.Find(id);
            return medicine;
        }

        public List<Medicines> GetMedicines()
        {
            return _medicineContext.Medicines.ToList();
        }
    }
}
