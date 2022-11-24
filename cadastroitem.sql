-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 24-Nov-2022 às 13:52
-- Versão do servidor: 10.4.24-MariaDB
-- versão do PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `meu_site`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `cadastroitem`
--

CREATE TABLE `cadastroitem` (
  `ID` int(9) NOT NULL,
  `Nome` varchar(50) NOT NULL,
  `Familia` varchar(10) NOT NULL,
  `Unidade` varchar(2) NOT NULL,
  `Situacao` varchar(15) NOT NULL,
  `Quantidade` int(50) NOT NULL,
  `Data_Cadastro` date NOT NULL,
  `Data_Licitacao` date NOT NULL,
  `Descricao` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cadastroitem`
--

INSERT INTO `cadastroitem` (`ID`, `Nome`, `Familia`, `Unidade`, `Situacao`, `Quantidade`, `Data_Cadastro`, `Data_Licitacao`, `Descricao`) VALUES
(6, '', '', '', 'ativo', 0, '2022-11-22', '2023-06-06', ''),
(6, 'teste', '', 'cm', 'emAnalise', 0, '2022-11-22', '2023-06-06', ''),
(6, '', '', 'CM', 'ativo', 0, '2022-11-22', '2023-06-06', ''),
(6, '', '', '', 'Ativo', 0, '2022-11-22', '2023-11-22', ''),
(6, '', '', '', 'Nenhum', 0, '2022-11-22', '0000-00-00', ''),
(5, 'aa', 'aa', 'AA', 'Ativo', 5, '2022-11-23', '2000-06-06', 'aa'),
(6, 'aa', 'aa', 'CM', 'Ativo', 5, '2022-11-24', '2023-06-06', ''),
(6, 'aa', 'aa', 'AA', 'Ativo', 5, '2000-06-06', '2000-07-06', 'a'),
(6, 'Teste', 'Teste Fami', 'AA', 'Ativo', 5, '2000-06-06', '2000-06-07', 'a');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
