﻿using FinancasApp.Domain.Entities;
using FinancasApp.Domain.Interfaces.Repositories;
using FinancasApp.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.Infra.Data.Repositories
{
    public class MovimentacaoRepository(DataContext dataContext)
        : BaseRepository<Movimentacao, Guid>(dataContext), IMovimentacaoRepository
    {

    }
}
