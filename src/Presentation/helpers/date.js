const dateFormat = (input) => {
    let date = new Date(input)
    let options = {
        year: 'numeric', month: 'numeric', day: 'numeric',
        hour: 'numeric', minute: 'numeric', second: 'numeric',
        timeZone: 'America/Recife'
    };

    date.setHours(date.getHours() - 3);
    
    return Intl.DateTimeFormat('pt-BR', options).format(date);
}

export default dateFormat