var express = require('express');
var app = express();

app.use(express.static('public_html'));

app.listen(8080);
