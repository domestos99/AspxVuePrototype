

<template>
    <a class="btn btn-primary" v-on:click="btnClicked" >Refresh Button</a>
</template>

<script>
    export default {
        name: 'RefreshButton',
        data() {
            return {

            }
        },
        methods: {
            btnClicked: function (event) {               
                console.log(event);
                return false;
            }
        }

    }
</script>

<style scoped>
</style>
