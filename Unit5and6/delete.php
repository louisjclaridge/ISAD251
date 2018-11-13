<?php
/**
 * Created by PhpStorm.
 * User: s1atkinson
 * Date: 10/11/2016
 * Time: 20:26
 */

    

//get the GET files from the string.
if(isset($_GET['tablename']))
{
    $tableName = $_GET['tablename'];
    $id = $_GET['id'];
    $idColumn = $_GET['idColumn'];
    $values = array($idColumn => $id);
    $result = delete($values, $tableName);
}
?>

<html>
<head>
    <meta charset="UTF-8">
    <title></title>
</head>
<body>
<p>
    <?php
    if($result>0)
    {
        echo 'DELETE has been successful';
    }
    else
        echo 'DELETE HAS FAILED';
    ?>

</p>
</body>

</html>

