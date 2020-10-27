using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using Persistencia.Crud.Interfaces;
using Persistencia.Models;
using Persistencia.Repositorio;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Persistencia.Crud
{
    public class CrudUsuario : ICrudUsuario, IDisposable

    {
        Context _context;

        public CrudUsuario(Context context)
        {
            _context = context;
        }

        public async Task<List<Usuario>> List()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public async Task<Usuario> GetObjById(int Id)
        {
            return await _context.Usuarios.FindAsync(Id);
        }

        public async Task Insert(Usuario e)
        {
            await _context.Usuarios.AddAsync(e);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Usuario e)
        {
            _context.Usuarios.Update(e);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Usuario e)
        {
            _context.Usuarios.Remove(e);
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
