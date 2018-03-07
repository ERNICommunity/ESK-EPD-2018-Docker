For ($i=0; $i -le 20; $i++) {
    $port = 2000 + $i
    $portExpression = "$port" + ":80"
    & docker run -d -p $portExpression dockerdemo:latest
}