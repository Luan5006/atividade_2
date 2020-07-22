﻿using Microsoft.AspNetCore.Mvc;
using PrevisaoTempoAPI.Models;
using PrevisaoTempoAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrevisaoTempoAPI.Controllers
{
    // Luan Antonio de Souza Santos - Matricula: 1816217

    [Route("api/endereco")]
    public class EnderecoAPIController : ControllerBase
    {
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoAPIController(IEnderecoRepository enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }

        [HttpGet]
        [Route("ListarEnderecos")]
        public IActionResult ListarEnderecos()
        {
            return Ok(_enderecoRepository.ListarEnderecos());
        }

        [HttpGet]
        [Route("ListarEnderecos/{cep}")]
        public IActionResult ListarEnderecos([FromRoute] string cep)
        {
            return Ok(_enderecoRepository.ListarEndereco(cep));
        }

        [HttpPost]
        [Route("CadastrarEndereco")]
        public IActionResult CadastrarEndereco([FromBody] Endereco endereco)
        {
            _enderecoRepository.Cadastrar(endereco);

            return Ok("SUCESSO!");
        }

        [HttpPut]
        [Route("AlterarEndereco")]
        public IActionResult AlterarEndereco([FromBody] Endereco endereco)
        {
            _enderecoRepository.AlterarEndereco(endereco);

            return Ok("SUCESSO!");
        }

        [HttpDelete]
        [Route("DeletarEndereco/{id}")]
        public IActionResult DeletarEndereco([FromRoute] int id)
        {
            _enderecoRepository.DeletarEndereco(id);

            return Ok("SUCESSO!");
        }
    }
}
