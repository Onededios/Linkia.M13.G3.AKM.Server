# Docker postgres container

## Download latest postgres image

docker pull postgres

## Run the container

docker run --name postgresBD -e POSTGRES_PASSWORD=root -e -p 5432:5432 postgres

## Enter into the container as user

su postgres

## Drop database

dropdb akmDB

## Create database

createdb akmDB

## Exec scripts

psql -d akmDB -a -f 01_CreateAllTables.sql