<?php
// validate an email

if (filter_var("jjoselon3167@hotmail.com", FILTER_VALIDATE_EMAIL) === false) {
  // bad email !!
}
