﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Repositories;

public class Entity<TId>:IEntityTimeStamps
{
    public TId Id { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? DeleteDate { get; set; }


    public Entity()
    {
        Id = default;
    }

    public Entity(TId id)
    {
        Id = id;
    }
}
