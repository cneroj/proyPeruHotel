﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Hotel
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioRegistroReserva" en el código y en el archivo de configuración a la vez.
    public class ServicioRegistroReserva : IServicioRegistroReserva
    {
        public bool RegistroReserva(DataRegistro objReserva)
        {
            Boolean blnexito = false;
            try
            {
                PeruHotelEntities MiHotel = new PeruHotelEntities();

                    MiHotel.usp_RegistrarReserva(objReserva.ReserFechaIngreso, objReserva.ReserFechaSalida, objReserva.ClieDni, objReserva.IdHabi1
                    , objReserva.IdHabi2, objReserva.IdHabi3);
              

                blnexito = true;
            }
            catch (Exception)
            {

                return blnexito;
            }
            return blnexito;
        }
    }
}
