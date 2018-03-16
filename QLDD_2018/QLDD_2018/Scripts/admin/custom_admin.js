$(document).ready(function(){
    $('.li_lang_select').click(function(){
        var ID = $(this).attr('data-id');
        $('.li_lang_select').removeClass('active');
        $(this).addClass('active');
        $('.lang_tab_content').hide();
        $(ID).show();
    });
});