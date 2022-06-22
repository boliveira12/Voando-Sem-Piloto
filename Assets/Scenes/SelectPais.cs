using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class SelectPais : MonoBehaviour
{
    List<string> paises = new List<string>()
    {
        "Uruguai",
        "Brasil",
        "Argentina",
        "EUA",
        "Argelia",
        "Franca",
        "Espanha",
        "Canada",
        "Irlanda",
        "Chile",
        "Venezuela",
        "Paraguai",
        "Bolivia",
        "Peru",
        "Equador",
        "Colombia",
        "Guiana",
        "Suriname",
        "Guiana Fracesa",
        "Panama",
        "Costa Rica",
        "Nicaragua",
        "Honduras",
        "El Salvador",
        "Guatemala",
        "Mexico",
        "Cuba",
        "Haiti",
        "Rep Dominicana",
        "Bahamas",
        "Alaska",
        "Dinamarca",
        "Jamaica",
        "Islandia",
        "Reino Unido",
        "Portugal",
        "Italia",
        "Suica",
        "Alemanha",
        "Holanda",
        "Belgica",
        "Austria",
        "Rep Checa",
        "Polonia",
        "Eslovaquia",
        "Hungria",
        "Eslovenia",
        "Bosnia",
        "Servia",
        "Croacia",
        "MonteNegro",
        "Macedonia do Norte",
        "Albania",
        "Grecia",
        "Belarus",
        "Ucrania",
        "Modavia",
        "Romenia",
        "Bulgaria",
        "Turquia",
        "Fed Russa",
        "Lituania",
        "Dinamarca",
        "Letonia",
        "Estonia",
        "Finlandia",
        "Suecia",
        "Noruega",
        "Russia",
        "Cazaquistao",
        "Turcomenistao",
        "Iran",
        "Georgia",
        "Azerbabao",
        "Armenia",
        "Mongolia",
        "China",
        "Coreia do Norte",
        "Coreia do Sul",
        "Japao",
        "Taiwan",
        "Filipinas",
        "Quirguistao",
        "Tadjiquistao",
        "Afeganistao",
        "Paquistao",
        "India",
        "Nepalm",
        "Butao",
        "Bangladesh",
        "Mianmar",
        "Tailandia",
        "Laos",
        "Vietna",
        "Camboja",
        "Malasia",
        "Brunei",
        "Indonesia",
        "Nova Guinea",
        "Australia",
        "Nova Zelandia",
        "Marrocos",
        "Argelia",
        "Mauritania",
        "Saara Ocidental",
        "Tunisia",
        "Libia",
        "Egito",
        "Sudao",
        "Chade",
        "Niger",
        "Mali",
        "Burkina Faso",
        "Senegai",
        "Guine Bissau",
        "Guine",
        "Serra Leoa",
        "Liberia",
        "Costa do Marfim",
        "Gana",
        "Togo",
        "Benin",
        "Nigeria",
        "Camaroes",
        "Republica Centro-Africa",
        "Sudao do Sul",
        "Etiopia",
        "Eritreia",
        "Republica Congo",
        "Congo",
        "Gabao",
        "Somalia",
        "Quenia",
        "Uganda",
        "Tanzania",
        "Ruanda",
        "Burundi",
        "Mocambique",
        "Madagascar",
        "Zambia",
        "Angola",
        "Namibia",
        "Botsuana",
        "Zimbabue",
        "Africa do Sul",
        "Lesoto",
        "Suazilandia",
        "Malaui",
        "Antartida",
        "Oman",
        "UAE",
        "Iemen",
        "Arabia Saudita",
        "Iraque",
        "Siria",
        "Jordania",
        "Israel"
    };

    public Text texto;
    public Text texto2;
    public Dropdown dropdown;
    public static string origem = "Afeganistao";
    public static string destino = "Afeganistao";

    public void IndexChanged(int index){ //país origem 
        texto.text = paises[index];
        origem = paises[index];
    } 
    
    public void ChangedIndex(int index2){ //país destino
        texto2.text = paises[index2];
        destino = paises[index2];
    }



    public void PopulateList()
    {
        paises.Sort();
        dropdown.AddOptions(paises);
    }

    void Start()
    {
        PopulateList();
    }
}
