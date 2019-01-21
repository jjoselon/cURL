<?php
// validate an email

if (filter_var("jjoselon3167@hotmail.com", FILTER_VALIDATE_EMAIL) === false) {
  // bad email !!
}

// Romper (rip) etiquetas HTML para evitar Cross-site Scripting
//http://php.net/manual/es/function.strip-tags.php#110280
function rip_tags($string) { 
    
    // ----- remove HTML TAGs ----- 
    $string = preg_replace ('/<[^>]*>/', ' ', $string); 
    
    // ----- remove control characters ----- 
    $string = str_replace("\r", '', $string);    // --- replace with empty space
    $string = str_replace("\n", ' ', $string);   // --- replace with space
    $string = str_replace("\t", ' ', $string);   // --- replace with space
    
    // ----- remove multiple spaces ----- 
    $string = trim(preg_replace('/ {2,}/', ' ', $string));
    
    return $string; 

}
