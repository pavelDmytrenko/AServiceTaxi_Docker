using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AServiceTaxi.DL
{
    public interface IDbContext
    {
        DbSet<Car> Car { get; set; }
        DbSet<Order> Order { get; set; }
        int SaveChange();
    }
}
