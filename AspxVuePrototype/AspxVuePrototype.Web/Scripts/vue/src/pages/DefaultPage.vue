<template>

    <div id="DefaultPage">

        <h1>Default page - Vue.JS</h1>

        <a class="btn btn-primary" v-on:click="getPerson" >Person console</a>

        <FullNameEditor v-model="fullName"></FullNameEditor>

        <RefreshButton></RefreshButton>
    </div>

</template>


<script>

    // import FullNameEditor from "../components/FullNameEditor";

    import RefreshButton from "../components/refresh-button/RefreshButton";
    import FullNameEditor from "../components/FullNameEditor";
    import PersonService from "../services/person.service";

    export default {
        name: 'DefaultPage',
        components: {
            FullNameEditor,
            RefreshButton
        },
        props: {
            msg: String
        },
        data() {
            return {
                fullName: 'Riki Fridrich'
            }
        },
        methods: {
            getPerson: function() {
                let a = new PersonService().getPersons();
                console.log(a);
            }
        }
    };

</script>

<style scoped>

</style>