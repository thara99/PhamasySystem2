using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhamasySystem2.Model;

namespace PhamasySystem2.MedicinesData
{
    public interface IMedicines
    {

        List<Medicines> GetMedicines();

        Medicines GetMedicine(Guid id);

        Medicines AddMedicine(Medicines medicine);

        void DeleteMedicine(Medicines medicine);

        Medicines EditMedicine(Medicines medicine);


    }
}
