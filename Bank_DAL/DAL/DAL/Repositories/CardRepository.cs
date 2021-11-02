using DAL.Entities;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class CardRepository :GenericRepository<Card>, ICard
    {
        public CardRepository(AutoDBContext context) : base(context)
        {

        }
    }
}
