using DataAccessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorkUOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Database _database;
        public UnitOfWork(Database database)
        {
            this._database = database;
        }

        private IArmiaRepository _Armia;
        private IBronRepository _Bron;
        private IDywizjaRepository _Dywizja;
        private IModelRepository _Model;
        private IStopienRepository _Stopien;
        private IZgloszenieRepository _Zgloszenie;
        private IZolnierzRepository _Zolnierz;
        public IArmiaRepository Armia
        {
            get
            {
                if (this._Armia == null)
                {
                    this._Armia = new ArmiaRepository(_database);
                }
                return this._Armia;
            }
        }

        public IBronRepository Bron
        {
            get
            {
                if (this._Bron == null)
                {
                    this._Bron = new BronRepository(_database);
                }
                return this._Bron;
            }
        }

        public IDywizjaRepository Dywizja
        {
            get
            {
                if (this._Dywizja == null)
                {
                    this._Dywizja = new DywizjaRepository(_database);
                }
                return this._Dywizja;
            }
        }

        public IModelRepository Model
        {
            get
            {
                if (this._Model == null)
                {
                    this._Model = new ModelRepository(_database);
                }
                return this._Model;
            }
        }

        public IStopienRepository Stopien
        {
            get
            {
                if (this._Stopien == null)
                {
                    this._Stopien = new StopienRepository(_database);
                }
                return this._Stopien;
            }
        }

        public IZgloszenieRepository Zgloszenie
        {
            get
            {
                if (this._Zgloszenie == null)
                {
                    this._Zgloszenie = new ZgloszenieRepository(_database);
                }
                return this._Zgloszenie;
            }
        }

        public IZolnierzRepository Zolnierz
        {
            get
            {
                if (this._Zolnierz == null)
                {
                    this._Zolnierz = new ZolnierzRepository(_database);
                }
                return this._Zolnierz;
            }
        }

        public int Complete()
        {
            return _database.SaveChanges();
        }

        public async Task<int> CompleteAsync()
        {
            return await _database.SaveChangesAsync();
        }
        public void Dispose() => _database.Dispose();
    }
}
