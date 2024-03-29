﻿using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class FavoriteList : Entity<Guid>
{
    public string ListName { get; set; }
    public Guid MaterialId { get; set; }
    public virtual ICollection<Material>? Materials { get; set; }
    public virtual Member? Member { get; set; }
}
