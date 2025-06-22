window.onbeforeunload = function () {
    // Send a logout request to the server
    fetch('/api/auth/logout', { method: 'POST', credentials: 'include' });
};