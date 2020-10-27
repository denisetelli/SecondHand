using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using Repositorio.Crud.Interfaces;
using Repositorio.Models;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Repositorio.Crud
{
    public class CrudPergunta : ICrudPergunta, IDisposable

    {
        Context _context;

        public CrudPergunta(Context context)
        {
            _context = context;
        }

        public async Task<List<Pergunta>> List()
        {
            return await _context.Perguntas.ToListAsync();
        }

        public async Task<Pergunta> GetObjById(int Id)
        {
            return await _context.Perguntas.FindAsync(Id);
        }

        public async Task Insert(Pergunta e)
        {
            await _context.Perguntas.AddAsync(e);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Pergunta e)
        {
            _context.Perguntas.Update(e);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Pergunta e)
        {
            _context.Perguntas.Remove(e);
            await _context.SaveChangesAsync();
        }

        #region Disposed https://docs.microsoft.com/pt-br/dotnet/standard/garbage-collection/implementing-dispose
        // Flag: Has Dispose already been called?
        bool disposed = false;
        // Instantiate a SafeHandle instance.
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);



        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                // Free any other managed objects here.
                //
            }

            disposed = true;
        }


        #endregion
    }
}
