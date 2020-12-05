using System;
using System.ComponentModel.DataAnnotations;

namespace calculajuros.ViewModels
{
    public class CalculoJurosViewModel
    {
        [Required]
        public decimal ValorInicial { get; set; }

        [Required]
        [Range(1, 12, ErrorMessage = "Meses deve ser um número entre 1 e 12.")]
        public int Meses { get; set; }
    }
}