using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class FilmeDominio
    {
        public void Adicionar(Filme fil)
        {
            try
            {
                using (CinemaEntities db = new CinemaEntities())
                {
                    db.Filme.Add(fil);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
                //MessageBox.Show(e.Message);
            }
        }
        public void Adicionar(Salas sala)
        {
            try
            {
                using (CinemaEntities db = new CinemaEntities())
                {
                    db.Salas.Add(sala);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
                //MessageBox.Show(e.Message);
            }
        }
        public void Adicionar(Sessoes sessao)
        {
            try
            {
                using (CinemaEntities db = new CinemaEntities())
                {
                    db.Sessoes.Add(sessao);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
                //MessageBox.Show(e.Message);
            }
        }
        public List<Genero> listarGeneros()
        {
            try
            {
                List<Genero> lista = new List<Genero>();
                using (CinemaEntities db = new CinemaEntities())
                {
                    lista = (from g in db.Genero orderby g.gen_filme select g).ToList();
                }
                return lista;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public List<Sessoes> listarSessoes()
        {
            try
            {
                List<Sessoes> lista = new List<Sessoes>();
                using (CinemaEntities db = new CinemaEntities())
                {
                    lista = (from s in db.Sessoes orderby s.ses_data select s).ToList();
                }
                return lista;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public Salas retornarSala(int id)
        {
            try
            {
                Salas sala = new Salas();
                using (CinemaEntities db = new CinemaEntities())
                {
                    sala = (from g in db.Salas where g.sal_id == id select g).FirstOrDefault();
                }
                return sala;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public List<Filme> listarFilmes()
        {
            try
            {
                List<Filme> lista = new List<Filme>();
                using (CinemaEntities db = new CinemaEntities())
                {
                    lista = (from f in db.Filme orderby f.fil_titulo select f).ToList();
                }
                return lista;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public List<Salas> listarSalas()
        {
            try
            {
                List<Salas> lista = new List<Salas>();
                using (CinemaEntities db = new CinemaEntities())
                {
                    lista = (from f in db.Salas orderby f.sal_id select f).ToList();
                }
                return lista;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public Filme SelecionarUltimoFilme()
        {
            Filme retorno;
            using (CinemaEntities db = new CinemaEntities())
            {
                retorno = (from e in db.Filme
                           select e).ToList().Last();
            }
            return retorno;
        }
        public void alterarSessao(Sessoes ses)
        {
            
            using (CinemaEntities db = new CinemaEntities())
            {
                db.Entry(ses).State = System.Data.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
