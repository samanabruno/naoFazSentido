﻿using System;
using System.Data;
using naoFazSentido.Banco;
using naoFazSentido.ObjetoDeTransferencia;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naoFazSentido.Negocio
{
    class Negocios
    {
        AcessoBancoDados bd;
        // coisas para tela de motorista CRUD
        public DataTable SelecionaTodosMotorista()
        {
            try
            {
                DataTable dt = new DataTable();
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * from motorista");
                return dt;
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar consultar as revisões: " + ex.Message);
            }
            finally
            {
                bd = null;
            }

        }
        public void Excluir(string Idcliente)
        {
            try
            {

                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "DELETE FROM motorista where CODIGO=" + Idcliente;
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar cadastrar o cliente: " + ex.Message);
            }
            finally
            {
                bd = null;
            }

        }
        public void inserirMotorista(DTOMotorista dto)
        {
            try
            {

                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "INSERT INTO motorista (NOME,CPF,DATA_NASCIMENTO,RG,ENDERECO,CIDADE,CEP,TELEFONE) values ('" + dto.NOME + "', '" + dto.CPF + "', '" + dto.DATA_NASCIMENTO + "', '" + dto.RG + "', '" + dto.ENDERECO + "', '" + dto.CIDADE + "', '" + dto.CEP + "', '" + dto.TELEFONE + "')";
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar cadastrar motorista " + ex.Message);
            }
            finally
            {
                bd = null;
            }
        }
        public void Atualizar(DTOMotorista dto, string codigo)
        {
            try
            {
                
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "UPDATE Motorista set NOME = '" + dto.NOME + "', CPF ='" + dto.CPF + "', DATA_NASCIMENTO ='" + dto.DATA_NASCIMENTO + "', RG ='" + dto.RG + "', ENDERECO ='" + dto.ENDERECO + "', CIDADE ='" + dto.CIDADE + "', CEP ='" + dto.CEP + "', TELEFONE ='" + dto.TELEFONE + "'where CODIGO ='" + codigo;
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar atualizar o motorista: " + ex.Message);
            }
            finally
            {
                bd = null;
            }

        }
        // coisas para tela de revisão
        public DataTable SelecionaTodasRevisoes()
            {
                try
                {
                    DataTable dt = new DataTable();
                    bd = new AcessoBancoDados();
                    bd.Conectar();
                    dt = bd.RetDataTable("SELECT * from manutecao");
                    return dt;
                }

                catch (Exception ex)
                {
                    throw new Exception("Erro ao tentar consultar as revisões: " + ex.Message);
                }
                finally
                {
                    bd = null;
                }

            }
            public void inserirrevisao(DTORevisoa dto)
        {
            try
            {
                
                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "INSERT INTO manutecao(tipo,Nome_oficina,quilometragen,Data_entrada,Hora_entrada,Data_saida,Hora_saida,Nome_item,quantidade,valor)values('" + dto.tipo + "', '" + dto.oficina + "', '" + dto.quilometragem + "', '" + dto.dataentrada + "', '" + dto.horaentrada + "', '" + dto.datasaida + "', '" + dto.horasaida + "', '" + dto.nomeitem + "', '" + dto.quantidade + "', '" + dto.preco + "')";
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar cadastrar revisão " + ex.Message);
            }
            finally
            {
                bd = null;
            }
        }
        // coisas para tela de veiculo CRUD
        public DataTable SelecionarVeiculo()
        {
            try
            {
                DataTable dt = new DataTable();
                bd = new AcessoBancoDados();
                bd.Conectar();
                dt = bd.RetDataTable("SELECT * from Carro");
                return dt;
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar consultar os veiculos: " + ex.Message);
            }
            finally
            {
                bd = null;
            }
        }
        public void ExcluirCar(string IdCar)
        {
            try
            {

                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "DELETE FROM Carro where PLACA =" + IdCar;
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar excluir o veiculo: " + ex.Message);
            }
            finally
            {
                bd = null;
            }
        }
        public void Insericar(DTOCarro DTO)
        {
            try
            {

                bd = new AcessoBancoDados();
                bd.Conectar();
                string comando = "INSERT INTO Carro (RENAVAM,MARCA,MODELO,PLACA,COMBUSTIVEL,COR,QUILOMETRAGEM) values ('" + DTO.Renavam + "', '" + DTO.Marca + "', '" + DTO.Modelo + "', '" + DTO.Placa + "', '" + DTO.Combustivel + "', '" + DTO.Cor + "', '" + DTO.Quilometragem +  "')";
                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar cadastrar motorista " + ex.Message);
            }
            finally
            {
                bd = null;
            }
        }


    }
}
