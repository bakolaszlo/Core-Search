<template>
    <div>{{ searchText }}</div>
</template>

<script>
    export default {
        data() {
            return {
                searchText: this.$route.params.searchText
            };
        },
        created() {
            var myHeaders = new Headers();
            myHeaders.append("Cookie", "AWSALB=NsilVlrK/n7Sg0ZliAuYOHRFM+q/n/lgwY/KbE2l4LsPhlnIKEMCYr84J23wYRPkt2N2zVe8pth45pVV/trGZTuYWR8phi+PTSPUJAgaItT4ZuT7RICDTSm2C22T; AWSALBCORS=NsilVlrK/n7Sg0ZliAuYOHRFM+q/n/lgwY/KbE2l4LsPhlnIKEMCYr84J23wYRPkt2N2zVe8pth45pVV/trGZTuYWR8phi+PTSPUJAgaItT4ZuT7RICDTSm2C22T; AWSALBTG=hMTEOQtGoNbnyn9YWB+rGzbQWFngyzek6Ky9UG1kzB60UpMjuX2sbnLzyxEOFiFKWG/9GSWprud5uG9MKL9rphgh9FaXz0zkRXG5meIcfsry7WDhpUuGIQFC+cM+lqKM1dTbA0uXgfo3UZ5XSn2VwgXFgM4P1nZHhEH4Hp1U9ZqORZeyYSE=; AWSALBTGCORS=hMTEOQtGoNbnyn9YWB+rGzbQWFngyzek6Ky9UG1kzB60UpMjuX2sbnLzyxEOFiFKWG/9GSWprud5uG9MKL9rphgh9FaXz0zkRXG5meIcfsry7WDhpUuGIQFC+cM+lqKM1dTbA0uXgfo3UZ5XSn2VwgXFgM4P1nZHhEH4Hp1U9ZqORZeyYSE=");

            var requestOptions = {
                method: 'GET',
                headers: myHeaders,
                redirect: 'follow'
            };

            fetch("https://core.ac.uk:443/api-v2/search/" + this.searchText + "?page=1&pageSize=10&apiKey=6M9mi4CgonGJQbvqyUxpzOseNIrlAHYS&search=Alaska", requestOptions)
                .then(response => response.text())
                .then(result => console.log(result))
                .catch(error => console.log('error', error));
        }
    }
    
</script>