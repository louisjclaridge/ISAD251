<?php

const DB_HOST = 'localhost';
const DB_USER = 'root';
const DB_PASSWORD = '';
const DB_DATABASE = 'isad251_db';


function getConnection()
{
    $conn = new PDO('mysql:host='.DB_HOST.';dbname='.DB_DATABASE, DB_USER, DB_PASSWORD);
    return $conn;
}

function getAll($tablename)
{
    $resultSet = getConnection()->query("SELECT * FROM ".$tablename);
	return $resultSet;
}

function insert($tablename, $parameters)
{
    
}

function edit($object)
{
    
}
function delete($id)
{
    
}




