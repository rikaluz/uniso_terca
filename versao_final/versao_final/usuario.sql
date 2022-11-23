-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 17-Nov-2022 às 17:12
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
-- Estrutura da tabela `usuario`
--

CREATE TABLE `usuario` (
  `id` int(11) NOT NULL,
  `nome` varchar(255) NOT NULL,
  `id_login` int(14) NOT NULL,
  `email` varchar(255) NOT NULL,
  `senha` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`id`, `nome`, `id_login`, `email`, `senha`) VALUES
(22, 'ieo', 1033, 'teste@hotmail.com', '$2a$08$OTU3OTU1MDAwNjM3NDVmOOzbhEq8SQ2pULKZ7CIxDji5PfvK677SG'),
(26, 'Ieo', 5, 'ieo@gmail.com', '$2a$08$MTc3MDQyODM0MDYzNzQ2MeM7Y7DnYFxNSmildVN.Cl/nQIqcBVUCC'),
(27, 'Leonardo', 103782, 'adm@hotmail.com', '$2a$08$NzQ0Njg2NjA4NjM3NDYyZeSxZIWW/1T1lXw8kBHpmdRacbpbYzjwO'),
(31, 'Mariena', 1906, 'mariena@hotmail.com', '$2a$08$MjUzODg0Mjk1NjM3NTIxZOyvT/0CnN.tb42bBPMp3Jg8hLp8.wk8a');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
