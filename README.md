# SalesWebMvc
SalesWebMvc - Projetos .NET C#

<h1>Projeto SalesWebMvc</h1>

<p>
  O projeto <strong>SalesWebMvc</strong> é um sistema de vendas desenvolvido como um exemplo prático para estudos em C# e ASP.NET Core MVC, utilizando a versão 8.0. 
  Este projeto tem como objetivo demonstrar a construção de um sistema web funcional, explorando conceitos fundamentais como CRUD, relacionamentos entre entidades, e filtragem de dados.
</p>

<h2>Exemplos</h2>

![image](https://github.com/user-attachments/assets/c927d30a-a465-4573-9a6d-9a4732aa0f24)


![image](https://github.com/user-attachments/assets/824d4de6-21ef-45da-b7d4-0b38350d95a9)


![image](https://github.com/user-attachments/assets/910800f6-d752-44fd-8553-faf8003f884c)


![image](https://github.com/user-attachments/assets/d3091ef3-cfc5-4d59-a449-d6bb52739abf)

![image](https://github.com/user-attachments/assets/c1e7a2b7-eff8-4141-9024-9b4e69421c5e)


![image](https://github.com/user-attachments/assets/c6c8f4cd-8a5e-4848-909a-ed92f1a8aa94)

![image](https://github.com/user-attachments/assets/81f2f6d9-f371-4e4e-b590-b09f5ac2592e)

![image](https://github.com/user-attachments/assets/e5dde04f-b378-494a-8c6e-fa3f562f9f6c)


![image](https://github.com/user-attachments/assets/c0572c0d-ab05-4f55-ba49-8378c2aa3973)


![image](https://github.com/user-attachments/assets/9e5b4f28-c400-48ca-84c4-9401e006653f)

![image](https://github.com/user-attachments/assets/6d097f1d-339b-4ead-be5c-8e32a0d6d021)


![image](https://github.com/user-attachments/assets/f4384912-aa58-442e-8e33-cce9bbb68978)


![image](https://github.com/user-attachments/assets/3e6afecf-117d-423b-a899-797b780c38fe)

![image](https://github.com/user-attachments/assets/cdc9c90c-b994-452d-b426-0c6d47acc5fb)

![image](https://github.com/user-attachments/assets/be285002-463e-4773-ba78-93751cbc5d04)


![image](https://github.com/user-attachments/assets/b97ed209-a556-4957-965a-0902ae83824a)


<h2>Funcionalidades Demonstradas</h2>
    <ul>
        <li>
            <strong>CRUD Completo</strong>: O projeto implementa operações CRUD (Create, Read, Update, Delete) para três entidades principais:
            <ul>
                <li><strong>Department</strong>: Representa os departamentos dentro de uma empresa, como Vendas, Marketing, e outros.</li>
                <li><strong>Sellers</strong>: Gerencia os vendedores associados a cada departamento, permitindo adicionar, editar e excluir vendedores.</li>
                <li><strong>Sales</strong>: Registra as vendas realizadas, associando cada venda a um vendedor específico.</li>
            </ul>
        </li>
        <li><strong>Relacionamentos entre Entidades</strong>: As entidades <em>Department</em>, <em>Sellers</em>, e <em>Sales</em> estão relacionadas de forma que, por exemplo, cada vendedor pertence a um departamento e cada venda é atribuída a um vendedor. 
          Este relacionamento é gerenciado através de mapeamento objeto-relacional (ORM), utilizando o Entity Framework.</li>
        <li>
            <strong>Filtros de Busca</strong>:
            <ul>
                <li><strong>Busca Simples por Data</strong>: Esta funcionalidade permite ao usuário filtrar as vendas com base em um intervalo de datas, demonstrando como aplicar filtros em consultas de banco de dados.</li>
                <li><strong>Busca Agrupada por Departamento</strong>: Um exemplo avançado de filtragem, onde as vendas são agrupadas por departamento, permitindo uma visualização organizada dos dados de vendas por setor.</li>
            </ul>
        </li>
    </ul>

<h2>Tecnologias Utilizadas</h2>
    <ul>
        <li><strong>C# e ASP.NET Core 8</strong>: A linguagem e o framework utilizados para desenvolver o backend do sistema, oferecendo uma base sólida para a construção de aplicações web modernas.</li>
        <li><strong>Entity Framework (Mapeamento Objeto-Relacional)</strong>: Utilizado para mapear as entidades do projeto para as tabelas do banco de dados MySQL, facilitando o acesso e manipulação dos dados.</li>
        <li><strong>MySQL</strong>: Banco de dados escolhido para armazenar as informações do sistema, demonstrando a integração de ASP.NET Core com bancos de dados relacionais.</li>
        <li><strong>HTML, CSS, JavaScript</strong>: Tecnologias front-end empregadas para construir a interface do usuário, proporcionando uma experiência responsiva e interativa.</li>
        <li><strong>Bootstrap</strong>: Framework CSS que auxilia na criação de uma interface visualmente agradável e compatível com diferentes dispositivos.</li>
    </ul>

