using ConstruirApp.Models;
using ConstruirApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstruirApp.Service
{
    class ObraService
    {

        List<Obra> _cacheObras;

        public void addObra(Obra _obra)
        {
            int id = GetMaxIdObra();
            _obra.ObraId = id++;
            _cacheObras.Add(_obra);
            JsonUtil.WriteFromObra(_cacheObras);
        }

        public void editObra(Obra _obra)
        {
            var index = _cacheObras.FindIndex(c => c.ObraId == _obra.ObraId);
            if (index != -1)
            {
                _cacheObras[index] = _obra;
                JsonUtil.WriteFromObra(_cacheObras);
            }

        }

        private int GetMaxIdObra()
        {
            int id = 1;
            foreach (Obra _obra in _cacheObras)
            {
                if (_obra.ObraId >= id)
                    id = _obra.ObraId;
            }
            return id;
        }

        private void LoadObrasInCache()
        {
            if (_cacheObras == null)
            {
                _cacheObras = JsonUtil.ReadToObra();
            }
        }

    }
}
