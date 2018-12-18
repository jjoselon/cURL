<?php

$ch = curl_init();

curl_setopt($ch, CURLOPT_URL, 'https://www.electrictoolbox.com/php-curl-http-referer/');
# Si CURLOPT_RETURNTRANSFER se establece a false o no se pone, `curl_exec()` imprimira el resultado de la petición sin más
curl_setopt($ch, CURLOPT_RETURNTRANSFER, 1);
curl_setopt($ch, CURLOPT_REFERER, 'http://php.net/manual/es/function.curl-setopt.php');

$html = curl_exec($ch);

echo $html;
