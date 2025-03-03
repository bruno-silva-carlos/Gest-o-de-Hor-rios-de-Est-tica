﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace indra.Web.Admin.Bibliotecas
{
    public class Sessao
    {
        HttpContextAccessor _context;

        public Sessao(IHttpContextAccessor contexto)
        {
            _context = (HttpContextAccessor)contexto;
        }

        //CRUD SESSÃO - CADASTRAR, ATUALIZAR, CONSULTAR, REMOVER 

        public void Cadastrar(string Key, string Valor)
        {
            _context.HttpContext.Session.SetString(Key, Valor);
        }

        public void Atualizar(string Key, string Valor)
        {
            if (Existe(Key))
            {
                _context.HttpContext.Session.Remove(Key);
            }

            _context.HttpContext.Session.SetString(Key, Valor);
        }

        public void Remover(string Key)
        {
            _context.HttpContext.Session.Remove(Key);
        }

        public string Consultar(string Key)
        {
            return _context.HttpContext.Session.GetString(Key);
        }

        public bool Existe(string Key)
        {
            if (_context.HttpContext.Session.GetString(Key) == null)
            {
                return false;
            }

            return true;
        }

        public void RemoverTodos()
        {
            _context.HttpContext.Session.Clear();
        }
    }
}
