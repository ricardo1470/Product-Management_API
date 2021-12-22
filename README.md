# Product-Management_API
---

## Table of Contents
* [Introduction](#introduction)
* [Installation](#installation)
* [Usage](#usage)
* [Tests](#tests)
* [License](#license)
* [Author](#author)

> ## [Introduction](#introduction)
---
API to manage products and suppliers which are stored in a database that uses PostgreSQL as the engine for data management.

> ## [Installation](#installation)
---
clone the repository: `git clone https://github.com/ricardo1470/Product-Management_API.git`

open the file using Visual Studio, must have dotnet 5.0 installed, run the script using the tools provided by the IDE

### Install PostgreSQL
* `sudo apt update`
* `sudo apt install postgresql postgresql-contrib`
* `sudo service postgresql start [stop, status, reload, restart]`

### Version Postgresql
`sudo -u postgres psql -c "SELECT version();"`

### Start Postgres Shell
* `sudo -u postgres psql`
* `pass= root`

### Set Password
* `ALTER USER postgres WITH PASSWORD 'root';`

### Basic Postgres Commands
* `\q`: Quit
* `\c` __database__: Connect to a database
* `\d` __table__: Show table definition including triggers
* `\dt` *.*: List tables from all schemas (if *.* is omitted will only show SEARCH_PATH ones)
* `\l`: List databases
* `\dn`: List schemas
* `\df`: List functions
* `\dv`: List views
* `\timing`: Show query timing stats

### Create Database

```postgres
DROP TABLE IF EXISTS public.products;

CREATE TABLE IF NOT EXISTS public.products
(
    id integer NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 999999 CACHE 1 ),
    productdescription text COLLATE pg_catalog."default",
    productstatus text COLLATE pg_catalog."default",
    dateofmanufacture date,
    validitydate date,
    suppliercode VARCHAR(500),
    supplierdescription text COLLATE pg_catalog."default",
    supplierphonenumber VARCHAR(50),
    CONSTRAINT products1_pkey PRIMARY KEY (id)

)

TABLESPACE pg_default;

    ALTER TABLE IF EXISTS public.products
    OWNER to postgres;
````

> ## [Usage](#usage)
---
the API uses Swagger as a testing tool, Swagger is pre-configured when creating the project as `ASP.NET Core Web Api`,
this tool allows us to test the implemented methods (`GET`, `POST`, `PUT`, `DELETE`).
from a webpage.
for more information visit: [Swagger](https://swagger.io/)

> ## [Tests](#tests)
---
the tests are implemented using [NUnit](https://www.nunit.org/)

> ## [License](#license)
---
MIT License
---

*<a href="url"><img src="https://www.apsl.net/media/apslweb/images/postgresql-logo.width-900.png" align="middle" width="100" height="60"></a>`Product-Management_API` is open source and therefore free to download and use without permission.*
> ## [Author](#author)
---

<div align="center">
<h2>
    Contact with me<img src="https://github.com/ricardo1470/MEVN/blob/main/src/public/images/Handshake.gif"  alt="handshake" height="32px">
</h2>

| [<img src="https://github.com/ricardo1470/MEVN/blob/main/src/public/images/GitHub.png" alt="Github logo" width="34">](https://github.com/ricardo1470/README/blob/master/README.md) | [<img src="https://github.com/ricardo1470/MEVN/blob/main/src/public/images/email.png" alt="email logo" height="32">](mailto:ricardo.alfonso.camayo@gmail.com) | [<img src="https://github.com/ricardo1470/MEVN/blob/main/src/public/images/linkedin-icon.png" alt="Linkedin Logo" width="32">](https://www.linkedin.com/in/ricardo-alfonso-camayo/) | [<img src="https://github.com/ricardo1470/MEVN/blob/main/src/public/images/twitter.png" alt="Twitter Logo" width="30">](https://twitter.com/RICARDO1470) |
|:---:|:---:|:---:|:---:|

</div>

---

> ## Built with
this project was built in: `.NET`, `PostgreSQL`, `Visual Studio 2020`


