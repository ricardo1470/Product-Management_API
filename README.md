# Product-Management_API
API Rest C#

> ### Create project
* dotnet new webapi -n "name file" --no-https

> ### run project
* dotnet run

> ### test project
* dotnet test

## Install PostgreSQL
* `sudo apt update`
* `sudo apt install postgresql postgresql-contrib`
* `sudo service postgresql start [stop, status, reload, restart]`

## Version Postgresql
`sudo -u postgres psql -c "SELECT version();"`

## Start Postgres Shell
* `sudo -u postgres psql`
* `pass= root`

## Set Password
* `ALTER USER postgres WITH PASSWORD 'root';`

## Basic Postgres Commands
* `\q`: Quit
* `\c` __database__: Connect to a database
* `\d` __table__: Show table definition including triggers
* `\dt` *.*: List tables from all schemas (if *.* is omitted will only show SEARCH_PATH ones)
* `\l`: List databases
* `\dn`: List schemas
* `\df`: List functions
* `\dv`: List views
* `\timing`: Show query timing stats

## Create Database

```postgres
DROP TABLE IF EXISTS public.products;
```

```postgres
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
```


```postgres
TABLESPACE pg_default;
```

```postgres
    ALTER TABLE IF EXISTS public.products
    OWNER to postgres;
````


> ## Built with
this project was built in: `.NET`, `PostgreSQL`, `Visual Studio 2020`


<div align="center">
<h2>
    Contact with me<img src="https://github.com/ricardo1470/MEVN/blob/main/src/public/images/Handshake.gif"  alt="handshake" height="32px">
</h2>

| [<img src="https://github.com/ricardo1470/MEVN/blob/main/src/public/images/GitHub.png" alt="Github logo" width="34">](https://github.com/ricardo1470/README/blob/master/README.md) | [<img src="https://github.com/ricardo1470/MEVN/blob/main/src/public/images/email.png" alt="email logo" height="32">](mailto:ricardo.alfonso.camayo@gmail.com) | [<img src="https://github.com/ricardo1470/MEVN/blob/main/src/public/images/linkedin-icon.png" alt="Linkedin Logo" width="32">](https://www.linkedin.com/in/ricardo-alfonso-camayo/) | [<img src="https://github.com/ricardo1470/MEVN/blob/main/src/public/images/twitter.png" alt="Twitter Logo" width="30">](https://twitter.com/RICARDO1470) |
|:---:|:---:|:---:|:---:|

</div>

---

## License
*<a href="url"><img src="https://www.apsl.net/media/apslweb/images/postgresql-logo.width-900.png" align="middle" width="100" height="60"></a>`Product-Management_API` is open source and therefore free to download and use without permission.*
